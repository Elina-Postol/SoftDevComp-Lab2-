using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    /// <summary>
    /// A class that describe special user in the system that do tester work
    /// </summary>
   public class QA: SystemUser ,IComperable<QA,QA>  {
       // public enum Proficiency { junior, middle, senior }

        public int QAId { get; set; }
        public string Proficiency;
        public QA() {

        }
        public QA(int developerId, string firstname, string lastname, int salary,string proficiency) {
            QAId = developerId;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Proficiency = proficiency;
        }
        public override string ToString() {
            return "QA ID: " + QAId + " First Name: " + FirstName + "   lastName: " + LastName + " Salary " + Salary + "  job position" + JobPosition + " Tasks " + AssignedTasks;
        }

        public int CompareTo(QA other,QA other2) {
         return other.Proficiency.CompareTo(other2.Proficiency);
        }

      

        //public  static bool operator <= (QA x, QA y) {
        //    return x.Proficiency <= y.Proficiency;
        //}
        //public static bool operator >=(QA x, QA y) {
        //    return x._value >= y._value;
        //            }
        //public static bool operator < (QA x, QA y) {
        //    return x._value < y._value;
        //}
        //public static bool operator >(QA x, QA y) {
        //    return x._value > y._value;
        //}

        //public static bool operator ==(QA x, QA y) {
        //    return x._value == y._value;
        //}
        //public static bool operator !=(QA x, QA y) {
        //    return x._value != y._value;
        //}

    }
}
