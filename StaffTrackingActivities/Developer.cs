using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StaffTrackingActivities {
    /// <summary>
    /// A class that describe special user in the system that will do developer work
    /// </summary>
      //public delegate int SalaryPayment(string message);
   public class Developer : SystemUser,IComperable<Developer,Developer > ,IEqualityComparer<Developer> {

       
        ////  public enum Proficiency { junior,middle,senior };
       public  string Proficiency { get; set; }
        public int DeveloperId { get; set; }
        public int Order { get; set; }

       // public enum Proficiency { junior, middle, senior };
        public Developer() {
           
        }

        
        protected virtual void OnSalaryPayment(string message) {
        SystemUser salaryPaid = new SystemUser();
  
        }
        protected virtual void OnSalaryPaid() {
          //  (SalaryPayment as SalaryPayment)?.Invoke(this);

       }

        
        public Developer(int developerId, string firstname, string lastname, int salary, string proficiency) {
            DeveloperId = developerId;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            Proficiency = proficiency;
                            }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(" Developer ID: ");
            sb.Append(DeveloperId);
            sb.Append("First Name: ");
            sb.Append(FirstName);
            sb.Append("   lastName: ");
            sb.Append(LastName);
            sb.Append("  job position ");
            sb.Append(JobPosition);
            sb.Append(" Proficiency ");
            sb.Append(Proficiency);
            sb.Append(" Salary ");
            sb.Append(Salary);
            sb.Append(" Tasks ");
            sb.Append(AssignedTasks);
            return sb.ToString();
        }
      
        public int CompareTo(Developer other, Developer other2) {
            int compare1result = other.Proficiency.CompareTo(other2.Proficiency);
            int compare2result =(int)other.Salary.CompareTo((int)other2.Salary);
            if (compare1result == 0 && compare2result == 0) return 0;
            else if (compare1result > 0 && compare2result == 0) return 1;
            else if (compare1result == 0 && compare2result > 0) return 1;
            else if (compare1result <0 && compare2result> 0) return 1;
            else if (compare1result >0 && compare2result > 0) return 1;
            else return -1;
                     
        }

  

        public bool Equals(Developer x, Developer y) {
            throw new NotImplementedException();
        }

        public int GetHashCode(Developer obj) {
            throw new NotImplementedException();
        }
        //public int CompareTo(Developer profeciency, Developer salary ) {
        //    this._value 
        //    return this._value.CompareTo(other._value);
        //}
        //public static bool operator <(Developer x, Developer y) {
        //    return x._value  < y._value;
        //}
        //public static bool operator <=(Developer x, Developer y) {
        //    return x._value <= y._value;
        //}
        //public static bool operator >(Developer x, Developer y) {
        //    return x._value > y._value;
        //}
        //public static bool operator >=(Developer x, Developer y) {
        //    return x._value >= y._value;
        //}
    }
}
