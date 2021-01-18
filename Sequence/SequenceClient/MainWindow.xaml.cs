using SequenceClient.SequenceService;
using System;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows;

namespace SequenceClient {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        SeqClient seqClient;

        public MainWindow() {
            InitializeComponent();

            seqClient = new SeqClient();
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e) {
            string seq = InputSequenceTextBox.Text.Clone() as string;
            var result = seqClient.Translate(seq);
            OutputSequenceTextBox.Text = result;
        }

    }

    public class SeqClient : System.ServiceModel.ClientBase<ISequenceService>, ISequenceService {
        public SeqClient() { }

        public SeqClient(string endpointConfigurationName) :
                base(endpointConfigurationName) { }

        public SeqClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) { }

        public SeqClient(string endpointConfigurationName,
            System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) { }

        public SeqClient(System.ServiceModel.Channels.Binding binding,
            System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) { }

        public string Translate(string seq) {
            try {
                return base.Channel.Translate(seq);
            } catch (EndpointNotFoundException) {
                return "Service is not running.";
            }

        }

        public Task<string> TranslateAsync(string seq) {
            throw new NotImplementedException();
        }
    }
}
