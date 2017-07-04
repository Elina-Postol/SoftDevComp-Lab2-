using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    /// <summary>
    /// A claas that describe special user in the system that do manager work
    /// </summary>
    public class Manager : SystemUser {
        public int ManagerId { get; set; }
        static public void TasksDistribution() {
            StaffWarehouse stafflist = new StaffWarehouse();
            List<Developer> developersList = stafflist.DevelopersList();
            List<QA> testersList = stafflist.QAList();
            Task[] tasksList = FillerTasks.TaskGenerator().ToArray();
            for (int i = 0; i < developersList.Count; i++) {
                developersList.ElementAt(i).AssignedTasks = (tasksList.ElementAt(i).TaskId);
                var t = tasksList.ElementAt(i);
            }
            for (int i = testersList.Count; i < 0; i--) testersList.ElementAt(i).AssignedTasks = tasksList.ElementAt(i).TaskId;
        }

        public static IEnumerable<QA> ReportGenerationg1() {
             StaffWarehouse stafflist = new StaffWarehouse();
            List<QA> testersList = stafflist.QAList();
            List < QA> SortedTestersList = testersList.OrderBy(t => t.Salary).ToList();
            return SortedTestersList;
        }
        public static IEnumerable<Developer> ReportGenerationg2() {
            StaffWarehouse stafflist = new StaffWarehouse();
            List<Developer> developersList = stafflist.DevelopersList();
           
            var developer = from d in developersList
                            where d.LastName == "Developer3"
                            select d;
            return developer;
        }
        public static IEnumerable <SystemUser> ReportGenerationg3() {
            StaffWarehouse stafflist = new StaffWarehouse();
            List<Developer> developersList = stafflist.DevelopersList();
            List<QA> testersList = stafflist.QAList();
            var developer = from d in developersList
                            where d.Proficiency=="senior"
                            select d;
         
            return developer;
        }
    }

}

