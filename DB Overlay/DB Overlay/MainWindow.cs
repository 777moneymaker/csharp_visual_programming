using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DB_Overlay {
    public partial class MainWindow : Form {

        private List<Person> person_list = new List<Person>();
        private int person_index = 0;
        private bool new_status = false;

        public MainWindow() {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.saveFileButton_Click);
            this.CenterToScreen();

            for (int i = 1; i <= 31; i++)
                this.BirthDaysComboBox.Items.Add(i.ToString());
            for (int i = 1; i <= 12; i++)
                this.BirthMonthsComboBox.Items.Add(i.ToString());
            for (int i = 1920; i <= 2020; i++)
                this.BirthYearsComboBox.Items.Add(i.ToString());

            this.loadList();
        }


        private void saveList() {
            //serialize
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string serializationFile = Path.Combine(dir, "people.bin");


            try {
                if (this.person_list.Count == 0)
                    return;

                using (Stream stream = File.Open(serializationFile, FileMode.Create)) {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bformatter.Serialize(stream, this.person_list);
                }
            } catch {
                MessageBox.Show("Error occured while saving list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("File saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void loadList() {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string serializationFile = Path.Combine(dir, "people.bin");

            if(!new FileInfo(serializationFile).Exists) {
                return;
            }

            //deserialize
            try {

                using (Stream stream = File.Open(serializationFile, FileMode.Open)) {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    this.person_list = (List<Person>)bformatter.Deserialize(stream);
                    if (this.person_list.Count == 0)
                        return;
                }
                MessageBox.Show("File Loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.setTextOnLabels(this.person_list[this.person_index]);
                return;
            } catch {
                MessageBox.Show("Error occured while saving list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void setTextOnLabels(Person p) {
            this.NameTextBox.Text = p.name;
            this.LastNameTextBox.Text = p.last_name;
            this.JobComboBox.Text = p.job;
            this.SexComboBox.Text = p.sex;
            this.BirthDaysComboBox.Text = p.day_birth.ToString();
            this.BirthMonthsComboBox.Text = p.month_birth.ToString();
            this.BirthYearsComboBox.Text = p.years_birth.ToString();
        }

        private void clearLabels() {
            foreach (Control x in this.Controls) {
                if (x.GetType() == typeof(TextBox) || x.GetType() == typeof(ComboBox))
                    x.ResetText();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {

            Person p;
            int days = 1, months = 1, years = 190;
            bool positive_status = int.TryParse(this.BirthDaysComboBox.Text, out days)
                                    && int.TryParse(this.BirthMonthsComboBox.Text, out months)
                                    && int.TryParse(this.BirthYearsComboBox.Text, out years);

            if (!positive_status) {
                MessageBox.Show("Error occured while creating new Person! Check if you have correct data or if you are in a creation mode.", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }


            if (this.new_status) {
                try {
                    p = new Person(this.NameTextBox.Text.ToString(),
                        this.LastNameTextBox.Text.ToString(),
                        this.JobComboBox.Text.ToString(),
                        this.SexComboBox.Text.ToString(),
                        days,
                        months,
                        years);
                    this.person_list.Add(p);
                    this.person_index++;
                    MessageBox.Show("Saved new person!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.new_status = false;
                    this.StatusLabel.Text = "Status: Editing";
                    this.PrevButton.Enabled = !PrevButton.Enabled;
                    this.NextButton.Enabled = !this.NextButton.Enabled;
                    this.DeleteButton.Enabled = !this.DeleteButton.Enabled;

                    return;
                } catch (Exception ex) {
                    MessageBox.Show("Error occured while creating new Person! Check if you have correct data or if you are in a creation mode.", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }
            } else {
                try {
                    p = this.person_list[this.person_index];
                    p.name = this.NameTextBox.Text.ToString();
                    p.last_name = this.LastNameTextBox.Text.ToString();
                    p.job = this.JobComboBox.Text.ToString();
                    p.sex = this.SexComboBox.Text.ToString();
                    p.day_birth = days;
                    p.month_birth = months;
                    p.years_birth = years;

                    MessageBox.Show("Re-saved the information about person!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.new_status = false;
                    this.StatusLabel.Text = "Status: Editing";

                    return;
                } catch {
                    MessageBox.Show("Error occured while creating new Person! Check if you have correct data or if you are in a creation mode.", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void PrevButton_Click(object sender, EventArgs e) {
            if (this.person_index == 0)
                return;
            else {
                try {
                    this.setTextOnLabels(this.person_list[--this.person_index]);
                } catch {
                    return;
                }
            }
        }
        private void NextButton_Click(object sender, EventArgs e) {
            if (this.person_index == this.person_list.Count - 1 || this.person_list.Count == 0) {
                return;
            }
            try {
                this.setTextOnLabels(this.person_list[++this.person_index]);
            } catch {
                return;
            }

        }

        private void NewButton_Click(object sender, EventArgs e) {
            this.new_status = !this.new_status;
            this.StatusLabel.Text = this.new_status ? "Status: Creation" : "Status: Editing";
            this.PrevButton.Enabled = !PrevButton.Enabled;
            this.NextButton.Enabled = !this.NextButton.Enabled;
            this.DeleteButton.Enabled = !this.DeleteButton.Enabled;
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            try {
                if (this.person_index == 0) {
                    this.person_list.Remove(this.person_list[this.person_index]);
                    this.clearLabels();
                } else {
                    this.person_list.Remove(this.person_list[this.person_index--]);
                    this.setTextOnLabels(this.person_list[this.person_index]);
                }
                return;
            } catch {
                return;
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e) {
            this.saveList();
        }
    }
}
