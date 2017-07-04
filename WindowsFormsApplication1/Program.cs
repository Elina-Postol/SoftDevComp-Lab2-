using StaffTrackingActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TextBox textBox = new TextBox();
            textBox.Text = "Test from program ";
            // Developer developer = new Developer();
            StaffWarehouse staff = new StaffWarehouse();
          List<Developer> developerList= staff.DevelopersListInput();
            StringBuilder sb = new StringBuilder() ;
            foreach (var developer in developerList) {

           
            sb.AppendFormat("{0}", developer.DeveloperId );
            sb.AppendFormat("{0}", developer.FirstName);
            sb.AppendFormat("{0}", developer.LastName);
            sb.AppendFormat("{0}", developer.Salary);
            sb.AppendFormat("{0}", developer.JobPosition);
          string text =  sb.ToString();
            //textbox.AppendText(text);
            //    textbox.Text = text;
                System.Diagnostics.Debug.WriteLine(developerList);
                textBox.AppendText("Append prprprpr");

            } 
 Application.Run(new Form1());
        }
    }
}
