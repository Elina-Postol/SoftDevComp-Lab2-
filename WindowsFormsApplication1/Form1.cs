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

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            TextBox textBox = new TextBox();
            textBox.Text = "Test from form1 ";
            textBox.AppendText("Append");
            //    textbox.Text = text;
            System.Diagnostics.Debug.WriteLine(" TTTTTTT ");
        }

        private void fontDialog1_Apply(object sender, EventArgs e) {

        }
    }
}

