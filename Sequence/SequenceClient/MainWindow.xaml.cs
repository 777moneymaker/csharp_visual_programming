using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Windows;
using SequenceClient.SequenceService;

namespace SequenceClient {
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Client = new SeqClient();
        }

        private SeqClient Client { get; }

        private void TranslateButton_Click(object sender, RoutedEventArgs e) {
            var result = Client.Translate(InputSequenceTextBox.Text.Clone() as string);
            OutputSequenceTextBox.Text = result;
        }
    }

    public class SeqClient : ClientBase<ISequenceService>, ISequenceService {
        public SeqClient() { }

        public SeqClient(string endpointConfigurationName) :
            base(endpointConfigurationName) { }

        public SeqClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress) { }

        public SeqClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress) { }

        public SeqClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress) { }

        public string Translate(string seq) {
            try {
                return Channel.Translate(seq);
            }
            catch (EndpointNotFoundException) {
                return "Service is not running.";
            }
        }

        public Task<string> TranslateAsync(string seq) {
            throw new NotImplementedException();
        }
    }
}