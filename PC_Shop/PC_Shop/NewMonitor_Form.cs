using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Shop {
    public partial class NewMonitor_Form : Form {

        MainWindow mainWindow;
        double sum;

        private List<Monitor> monitor_list;

        public NewMonitor_Form(MainWindow main_window) {
            InitializeComponent();
            this.mainWindow = main_window;
            this.monitor_list = main_window.MONITORS;

            foreach(var m in this.monitor_list) {
                this.MonitorsListBox.Items.Add(m);
            }
        }

        public void updateMonitors() {
            foreach(Monitor m in this.mainWindow.MONITORS) {
                if (!this.MonitorsListBox.Items.Contains(m)) {
                    this.MonitorsListBox.Items.Add(m);
                }
            }
        }

        private void MonitorsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            this.MonitorPriceTextBox.Text = ((Monitor)this.MonitorsListBox.SelectedItem).PRICE.ToString();
            this.sum = ((Monitor)this.MonitorsListBox.SelectedItem).PRICE;
        }

        private void CancelMonitorButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AcceptMonitorButton_Click(object sender, EventArgs e) {
            if (this.mainWindow.PRICE == 0) {
                this.mainWindow.PRICE = sum;
            } else {
                this.mainWindow.PRICE += sum;
            }

            if (this.mainWindow.STR_PRICE == "") {
                this.mainWindow.STR_PRICE = sum.ToString();
            } else {
                double current_sum = 0;
                try {
                    current_sum = double.Parse(this.mainWindow.STR_PRICE);
                    current_sum += this.sum;
                    this.mainWindow.STR_PRICE = current_sum.ToString();
                } catch (FormatException) {
                    this.mainWindow.STR_PRICE = "0";
                }
            }

            this.mainWindow.MONITOR = (Monitor)this.MonitorsListBox.SelectedItem;
            this.mainWindow.updatePrice();
            this.Close();
        }
    }
}
