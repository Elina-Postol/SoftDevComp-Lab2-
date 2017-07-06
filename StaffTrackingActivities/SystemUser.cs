using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    /// <summary>
    /// Base class that describe system user
    /// </summary>

    public class SystemUser {

        public delegate void DisplaySalaryMessage(string message);
        public event DisplaySalaryMessage PaySalary;

        public delegate int SalaryPayment(string message);
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string JobPosition { get; set; }//=JobPosition [ "Developer", "QA", "Manager" ];
                                               // public enum Proficiency {junior,middle,senior};
        public int Salary { get; set; }
        public int AssignedTasks { get; set; }
        public SystemUser() {

        }
        public void PaySalaryPart(int sum) {

            if (PaySalary != null)

                PaySalary("Paid part:  " + sum);

        }

    }
}


