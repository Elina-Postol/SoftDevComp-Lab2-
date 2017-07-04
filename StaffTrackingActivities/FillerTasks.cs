using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    /// <summary>
    /// Class for tasks generation
    /// </summary>
    public class FillerTasks : Task {

        public static HashSet<Task> TaskGenerator() {
            Random random = new Random();
            var tasksList = new HashSet<Task>(TaskItemEqualityComparer.Instance);
            for (int i = 0; i < 22; i++) {
                tasksList.Add(new Task() { TaskId = random.Next(0, 22), Difficulty = random.Next(2, 10), Estimation = random.Next(1, 12), TaskName = NameGenerator() }); //task.TaskId= random.Next(0, 22));
            }
            return tasksList;

        }
        public static string NameGenerator() {
            int nameLength = 8;
            Random randomValue = new Random();
            int[] randomValuesList=new int[nameLength];
            StringBuilder name = new StringBuilder();
            string[] a = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i < nameLength; i++) {
                randomValuesList[i]=randomValue.Next(a.Count());
            }
            for (int i = 0; i < nameLength; i++) 
                {    name.Append(a[randomValuesList[i]]);
            }

            return name.ToString();
        }
    }
}
