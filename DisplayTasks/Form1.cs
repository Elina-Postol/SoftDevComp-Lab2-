using StaffTrackingActivities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StaffTrackingActivities.SystemUser;

namespace DisplayTasks {
    public partial class Form1 : Form {
        public enum Proficiency { junior, middle, senior };
        public Form1() {
            InitializeComponent();
            comboBox1.Text = "Select proficiency";
            comboBox1.Items.Add(Proficiency.junior);
            comboBox1.Items.Add(Proficiency.middle);
            comboBox1.Items.Add(Proficiency.senior);

            textBox1.Text = "Input Salary";
            //  comboBox1.DataSource = stafflist.testingEngineer.Select(s => s.Proficiency);

            comboBox1.DisplayMember = "Proficiency";
            comboBox1.ValueMember = "Proficiency";

        }

        private void button1_Click(object sender, EventArgs e) {
            HashSet<StaffTrackingActivities.Task> displayTasks = new HashSet<StaffTrackingActivities.Task>();
            displayTasks = FillerTasks.TaskGenerator();
            this.Controls.Add(listBox1);
            foreach (var item in displayTasks) {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            HashSet<StaffTrackingActivities.Task> displayTasks = new HashSet<StaffTrackingActivities.Task>();
            displayTasks = FillerTasks.TaskGenerator();
            foreach (var item in displayTasks) {
                listBox1.Text.Insert(1, item.ToString());
            }

            //Items.Add(displayTasks);
        }

        private void button2_Click(object sender, EventArgs e) {
            StaffWarehouse stafflist = new StaffWarehouse();
            string text = "";
            this.Controls.Add(listBox1);
            if (comboBox1.SelectedItem == null ^ textBox1.Text == null) {
                MessageBox.Show("Salary number for compare must be input. Prociciency must be selected to have compare results.");

            } else {
                string result = comboBox1.SelectedItem.ToString();
                int salary = Convert.ToInt32(textBox1.Text);
                string g = comboBox1.SelectedText;
                // if (result != null) {
                foreach (var item in stafflist.CompareDevelopers(result, salary)) {
                    text = item.ToString();
                    listBox1.Items.Add(text);
                    // }
                }
                //stafflist.CompareQA();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            var result = comboBox1.SelectedValue;
            if (result != null) {
                MessageBox.Show(result.ToString());
            }




            //string acct =  comboBox1.SelectedValue.ToString();


        }
        //public event SystemUser.DisplaySalaryMessage SalaryPaid;

        private void button3_Click(object sender, EventArgs e) {
           Manager.TasksDistribution();

            MessageBox.Show("This button will be implemented later", "Need to make choise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //  SystemUser.SalaryPayment mydelegate = SystemUser.SalaryPayment(systUser.FirstName);
            //   del MyDelegate = new del();
            //  systUser.salarypaid("Test", systUser.salarypayment);
            //  del.


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            foreach (var item in Manager.ReportGenerationg1() ) {
           
                listBox1.Items.Add(item.ToString());
            } 
        }

        private void button5_Click(object sender, EventArgs e) {
           foreach (var item in Manager.ReportGenerationg2()) {

                listBox1.Items.Add(item.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            foreach (var item in Manager.ReportGenerationg3()) {

                listBox1.Items.Add(item.ToString());
            }
        }
    }
}
