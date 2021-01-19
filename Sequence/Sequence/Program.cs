using System;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using Bio.Algorithms.Translation;
using Bio.IO.FastA;

namespace Sequence {
    [ServiceContract]
    public interface ISequenceService {
        [OperationContract]
        string Translate(string seq);
    }

    public class SequenceService : ISequenceService {
        public string Translate(string seq) {
            try {
                var parser = new FastAParser();
                var byteArray = Encoding.UTF8.GetBytes(seq);
                Bio.Sequence result;
                using (var stream = new MemoryStream(byteArray)) {
                    result = parser.Parse(stream).First() as Bio.Sequence;
                }

                var transcribed = Transcription.Transcribe(result);

                return ProteinTranslation.Translate(transcribed) is Bio.Sequence translated ? translated.ConvertToString() : "Couldn't translate to protein.";
            }
            catch {
                return "Invalid operation. Check your sequence. Check your format (must be FASTA).";
            }
        }
    }

    internal class Program {
        private static readonly Uri BaseAddress = new Uri("http://localhost:8080/seq");

        private static void Main(string[] args) {
            using (var host = new ServiceHost(typeof(SequenceService), BaseAddress)) {
                // Enable metadata publishing.
                var smb = new ServiceMetadataBehavior {
                    HttpGetEnabled = true, MetadataExporter = {PolicyVersion = PolicyVersion.Policy15}
                };
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", BaseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}