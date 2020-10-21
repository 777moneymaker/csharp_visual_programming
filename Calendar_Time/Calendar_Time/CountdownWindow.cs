using System;
using System.Threading;
using System.Windows.Forms;

namespace Calendar_Time {
    public partial class CountdownWindow : Form {

        // General timer.
        System.Windows.Forms.Timer alarm = new System.Windows.Forms.Timer();

        public CountdownWindow() {
            InitializeComponent();
            this.minutesBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Getter for subjectBox's text.
        public string subjectText {
            get => this.subjectBox.Text;
            set => this.subjectBox.Text = value;
        }

        // Function that is called on every "tick". In this case "tick" will be every interval that is in Minutes Box.
        private void startTimerButton_Click(object sender, EventArgs e) {
            double minutes = 0;

            // Try parse the number of minutes. Return if exception.
            try {
                minutes = double.Parse(this.minutesBox.Text);
            } catch (Exception) {
                return;
            }

            alarm.Interval = (int)(1000 * 60 * minutes);
            alarm.Tick += new EventHandler(showAlarm); // Event subscription.
            alarm.Start();
            this.startTimerButton.Text = "Timer Enabled!";
        }

      

        // Show new Alarm Window.
        private void showAlarm(object sender, EventArgs e) {
            alarm.Stop();
            int numberOfWindows = 0;

            try {
               numberOfWindows =  int.Parse(this.numberOfWindows_textBox.Text);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            for(int i = 0; i < numberOfWindows; i++) {
                AlarmWindow alarm_window = new AlarmWindow(this.subjectText);
                alarm_window.Show();
            }
        }

    }
}
