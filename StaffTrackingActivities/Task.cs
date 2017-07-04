using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    /// <summary>
    /// A pool of tasks for developers
    /// </summary>/// 
   public class Task: IEqualityComparer<Task>  {
        private static readonly Task _instance = new Task();
        public static Task Instance { get { return _instance; } }
        public Task() {
                
        }


        public int Estimation { get; set; }
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public int Difficulty { get; set; }
        enum Proirity {critical, high, medium, low }
        enum Status {done, inProgress, test }

        public override string ToString() {
            return "Task ID: " + TaskId + " Task Name: " + TaskName + "   Difficulty: " + Difficulty + "  Estimation " + Estimation;
        }

        public bool Equals(Task x, Task y) {
            if (x.Difficulty.Equals(y.Difficulty) && x.TaskName.Equals(y.TaskName) && x.Estimation.Equals(y.Estimation))
              {
                     return true;
            } else return false;
                          
        }

        public int GetHashCode(Task obj) {
           return obj.TaskName.ToUpperInvariant().GetHashCode()^obj.Difficulty.GetHashCode()^obj.Estimation.GetHashCode();
        }
    }
}
