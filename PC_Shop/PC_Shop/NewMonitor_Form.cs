﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PC_Shop {
    public partial class NewMonitor_Form : Form {

        // Ref to base window.
        private readonly MainWindow mainWindow;
        // Summed price.
        public double Sum { get; set; }
        // Summed monitors.
        private List<Monitor> Monitors { get; set; }

        public NewMonitor_Form(MainWindow main_window) {
            InitializeComponent();
            this.mainWindow = main_window;
            this.Monitors = main_window.Monitors;
            this.MonitorsListBox.Items.AddRange(this.Monitors.ToArray());
            
        }

        // Add new monitors to list of all monitors.
        public void updateMonitors() {
            var unAdded = this.mainWindow.Monitors.Where(m => !this.MonitorsListBox.Items.Contains(m));
            unAdded.ToList<Monitor>().ForEach(m => this.MonitorsListBox.Items.Add(m));
        }
        // When Selected Monitor changed.
        private void MonitorsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                this.MonitorPriceTextBox.Text = ((Monitor)this.MonitorsListBox.SelectedItem).Price.ToString();
            } catch (NullReferenceException) {
                return;
            }

            this.Sum = ((Monitor)this.MonitorsListBox.SelectedItem).Price;
        }

        private void CancelMonitorButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Accept selected item on AcceptButton click.
        private void AcceptMonitorButton_Click(object sender, EventArgs e) {

            if (this.MonitorsListBox.SelectedItem is null) {
                MessageBox.Show("No monitor selected!");
                return;
            }

            this.mainWindow.Price += this.Sum;
            this.mainWindow.Monitor = (Monitor)this.MonitorsListBox.SelectedItem;
            this.mainWindow.updatePrice();
            this.Close();
        }
    }
}
