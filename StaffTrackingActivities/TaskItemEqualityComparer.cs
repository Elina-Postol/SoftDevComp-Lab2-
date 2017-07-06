using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    class TaskItemEqualityComparer : IEqualityComparer<Tasks> {
        private static readonly Tasks _instance = new Tasks();
        public static Tasks Instance { get { return _instance; } }
         private void Task() { }
        public bool Equals(Tasks x, Tasks y) {
            if ( x.TaskName.Equals(y.TaskName)) { //&&x.Difficulty.Equals(y.Difficulty) && x.Estimation.Equals(y.Estimation)) {
                return true;
            } else return false;

        }

        public int GetHashCode(Tasks obj) {
            return obj.TaskName.ToUpperInvariant().GetHashCode();// ^ obj.Difficulty.GetHashCode() ^ obj.Estimation.GetHashCode();
        }
    }
}
