using System;
using System.Windows.Forms;

namespace Calendar_Time {
    public partial class CalendarWindow : Form {
        public CalendarWindow() {
            InitializeComponent();
        }

        // Calculates elapsed days and parses as string.
        private void calculateButton_Click(object sender, EventArgs e) {
            this.calculatedDaysBox.Text = "Days: " + Math.Abs((this.toCalendar.SelectionRange.Start - this.fromCalendar.SelectionRange.Start).TotalDays).ToString();
        }

    }
}
