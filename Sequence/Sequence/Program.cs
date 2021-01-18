using System;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Sequence {
    [ServiceContract]
    public interface ISequenceService {
        [OperationContract]
        string Translate(string seq);
    }

    public class SequenceService : ISequenceService {

        public string Translate(string seq) {
            try {
                var parser = new Bio.IO.FastA.FastAParser();
                byte[] byteArray = Encoding.UTF8.GetBytes(seq);
                MemoryStream stream = new MemoryStream(byteArray);

                Bio.Sequence result = parser.Parse(stream).First() as Bio.Sequence;
                var transcribed = Bio.Algorithms.Translation.Transcription.Transcribe(result);
                var translated = Bio.Algorithms.Translation.ProteinTranslation.Translate(transcribed) as Bio.Sequence;

                return translated.ConvertToString();
            } catch {
                return "Invalid operation. Check your sequence. Check your format (must be FASTA).";
            }


        }
    }

    class Program {
        static Uri baseAddress = new Uri("http://localhost:8080/seq");
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(SequenceService), baseAddress)) {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
