using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Calendar_Time {
    public partial class mainWindow : Form {

        // Main timer format. Only format changes, timer stays the same.
        private string timeFormat = "HH:mm:ss";
        private bool isBinary = false;
        public mainWindow() {
            InitializeComponent();
        }

        // General form load.
        private void mainWindow_Load(object sender, EventArgs e) {
            this.generalTimer.Start();
        }

        // Function that is called on every "tick".
        private void generalTimer_tick(object sender, EventArgs e) {
            if (this.isBinary) {
                this.timeLabel.Text = DateTime.Now.ToBinary().ToString();
            } else {
                this.timeLabel.Text = DateTime.Now.ToString(this.timeFormat);
            }
        }

        // Changes the format to EU.
        private void EUHourStrip_Click(object sender, EventArgs e) {
            this.isBinary = false;
            this.timeFormat = "HH:mm:ss";
        }

        // Changes the format to US.
        private void USHourStrip_Click(object sender, EventArgs e) {
            this.isBinary = false;
            this.timeFormat = "hh:mm:ss tt";
        }

        // Creates and shows new Calendar Window on click.
        private void daysStrip_Click(object sender, EventArgs e) {
            CalendarWindow calendar_window = new CalendarWindow();
            calendar_window.Show();
        }

        // Creates and shows new Timer Window on click.
        private void timerStrip_Click(object sender, EventArgs e) {
            CountdownWindow countdown_window = new CountdownWindow();
            countdown_window.Show();
        }

        private void binStrip_Click(object sender, EventArgs e) {
            this.isBinary = true; 
        }
    }
}
