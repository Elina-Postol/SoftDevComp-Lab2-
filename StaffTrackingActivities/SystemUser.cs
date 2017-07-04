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
        //public  delegate void DisplaySalaryMessage(string message);
        public delegate int SalaryPayment(string message);
        public string FirstName { get; set; }
        public string LastName { get; set; }

       public string JobPosition { get; set; }//=JobPosition [ "Developer", "QA", "Manager" ];
                                              // public enum Proficiency {junior,middle,senior};
        public int Salary { get; set; }
       public  int  AssignedTasks { get; set; }
        public SystemUser() {
                
        }
        //public event SalaryPayment salarypayment;
        //public EventHandler salarypaid;
        //public void GetSalary(string message) {
        //    for (int i = 0; i < 6; i++) {
        //        OnSalaryPayment("Do payment");
        //    }

        //    OnSalaryPaid();
        //}
        //protected virtual void OnSalaryPayment(string message) {
        //    var del = salarypayment as SalaryPayment;
        //    del(message);
        //}
        //protected virtual void OnSalaryPaid() {
        //    var del = salarypayment as SalaryPayment;
        //    if (del != null) {
        //        del(null);
        //    }

        }


       // public string DoTask(DisplaySalaryMessage messageTarget) {
          //  int i = 10;
        //    ++i;
         //   messageTarget(i.ToString());
         //   return "Ok";
      //  }
       // static void SalaryPay() {
           // DisplaySalaryMessage sal1=new DisplaySalaryMessage();
          
        }


