using System;
using System.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace Calendar_Time {
    public partial class AlarmWindow : Form {

        public AlarmWindow(string msg) {
            InitializeComponent();
            this.subjectBox.Text = msg;
        }

        
        private void okButton_Click(object sender, System.EventArgs e) {
            this.Close();
        }

    }
}
