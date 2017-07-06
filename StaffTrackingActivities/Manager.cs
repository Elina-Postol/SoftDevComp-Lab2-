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
        static public List<Developer> TasksDistribution() {
            StaffWarehouse stafflist = new StaffWarehouse();
            List<Developer> developersList = stafflist.DevelopersList();
            List<QA> testersList = stafflist.QAList();
            Tasks[] tasksList = FillerTasks.TaskGenerator().ToArray();
          
            for (int i = 0; i < developersList.Count; i++) {
                developersList.ElementAt(i).AssignedTasks = (tasksList.ElementAt(i).TaskId);
                var t = tasksList.ElementAt(i);
               
        }
           
            for (int i = testersList.Count; i < 0; i--) testersList.ElementAt(i).AssignedTasks = tasksList.ElementAt(i).TaskId;
            return developersList;
        }


        public static IEnumerable<QA> ReportGenerationg1() {
            StaffWarehouse stafflist = new StaffWarehouse();
            List<QA> testersList = stafflist.QAList();
            List<QA> SortedTestersList = testersList.OrderBy(t => t.Salary).ToList();
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
        public static IEnumerable<SystemUser> ReportGenerationg3() {
            StaffWarehouse stafflist = new StaffWarehouse();
            List<Developer> developersList = stafflist.DevelopersList();
            List<QA> testersList = stafflist.QAList();
            var developer = from d in developersList
                            where d.Proficiency == "senior"
                            select d;

            return developer;
        }

        public static IEnumerable<Tasks> ReportGeneration4() {
            IEnumerable<Tasks> tasklist = FillerTasks.TaskGenerator();
            var taskdiffucaltyrate = tasklist.Where(t => t.Difficulty <= 5 && t.Estimation <= 10)
                   .OrderByDescending(t => t.Estimation);

            return taskdiffucaltyrate;
        }
        public static List<string> ReportGeneration5() {
            StaffWarehouse stafflist = new StaffWarehouse();
            IEnumerable<Tasks> tasklist = FillerTasks.TaskGenerator();
            List<Developer> devlist = new List<Developer>();
            devlist = TasksDistribution();
            List<string> report5 = new List<string>();
            var taskdiffucaltyrate = from t in tasklist
                                     join d in devlist
                                     on t.TaskId equals d.AssignedTasks
                                     where t.Estimation <= 10
                                     select new {
                                         developerFN = d.FirstName,
                                         developerLN = d.LastName,
                                         task = t.TaskName,
                                         estimation = t.Estimation,
                                     };

            foreach (var item in taskdiffucaltyrate) {
                report5.Add($"\n Developer name {item.developerFN}  {item.developerLN} Task name: {item.task} Estimation: {item.estimation}");

            }
            return report5;
        }
    }

}

