using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    class TaskItemEqualityComparer : IEqualityComparer<Task> {
        private static readonly Task _instance = new Task();
        public static Task Instance { get { return _instance; } }
         private void Task() { }
        public bool Equals(Task x, Task y) {
            if ( x.TaskName.Equals(y.TaskName)) { //&&x.Difficulty.Equals(y.Difficulty) && x.Estimation.Equals(y.Estimation)) {
                return true;
            } else return false;

        }

        public int GetHashCode(Task obj) {
            return obj.TaskName.ToUpperInvariant().GetHashCode();// ^ obj.Difficulty.GetHashCode() ^ obj.Estimation.GetHashCode();
        }
    }
}
