using StaffTrackingActivities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void TaskGeneration_Click(object sender, EventArgs e) {
            HashSet<StaffTrackingActivities.Tasks> displayTasks = new HashSet<StaffTrackingActivities.Tasks>();
           this.Controls.Add(MyDisplay);
            //Task T = new Task(() => {
                displayTasks = FillerTasks.TaskGenerator();
               // TaskScheduler.FromCurrentSynchronizationContext();
  
                foreach (var item in displayTasks) {
                    MyDisplay.Items.Add(item.ToString());
                  //  Thread.Sleep(10);
                }
              
         // });
          //  T.Start();
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
          
        }

        private void DeveloperCompareClick(object sender, EventArgs e) {
            StaffWarehouse stafflist = new StaffWarehouse();
            string text = "";
            this.Controls.Add(MyDisplay);
            if (comboBox1.SelectedItem == null ^ textBox1.Text == null) {
                MessageBox.Show("Salary number for compare must be input. Prociciency must be selected to have compare results.");

            } else {
                string result = comboBox1.SelectedItem.ToString();
                int salary = Convert.ToInt32(textBox1.Text);
                string g = comboBox1.SelectedText;
                // if (result != null) {
                foreach (var item in stafflist.CompareDevelopers(result, salary)) {
                    text = item.ToString();
                    MyDisplay.Items.Add(text);
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

        }
     

        private void PaySalary(object sender, EventArgs e) {
           Manager.TasksDistribution();
           SystemUser salaryPay = new SystemUser();
            salaryPay.PaySalary += ShowMessage;
            salaryPay.PaySalaryPart(50);
           
           // MessageBox.Show("This button will be implemented later", "Need to make choise", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        public  void ShowMessage(string message) {
            
            MyDisplay.Items.Add(message); 
    }

        private void SalaryInput_TextChanged(object sender, EventArgs e) {

        }

        private void Report1_Click(object sender, EventArgs e) {
            foreach (var item in Manager.ReportGenerationg1() ) {
           
                MyDisplay.Items.Add(item.ToString());
            } 
        }

        private void Report2_Click(object sender, EventArgs e) {
           foreach (var item in Manager.ReportGenerationg2()) {

                MyDisplay.Items.Add(item.ToString());
            }
        }

        private void Report3_click(object sender, EventArgs e) {
            foreach (var item in Manager.ReportGenerationg3()) {

                MyDisplay.Items.Add(item.ToString());
            }
        }

        private void Report4_Click(object sender, EventArgs e) {
            foreach (var item in Manager.ReportGeneration4()) {

                MyDisplay.Items.Add(item.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            foreach (var item in Manager.ReportGeneration5()) {

                MyDisplay.Items.Add(item.ToString());
            }
        }
    }
}
