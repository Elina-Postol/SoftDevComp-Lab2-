using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    /// <summary>
    /// Class for tasks generation
    /// </summary>
    public class FillerTasks : Tasks {

        public static HashSet<Tasks> TaskGenerator() {
            // Random random = new Random();
            Random random = new Random(Guid.NewGuid().GetHashCode());
            var tasksList = new HashSet<Tasks>(TaskItemEqualityComparer.Instance);
            for (int i = 0; i < 22; i++) {
                Task<int> t_taskId = Task.Factory.StartNew(() => { return  random.Next(1, 20); });
                Task<int> t_difficulty = Task.Factory.StartNew(() => { return random.Next(1, 20); });
                Task<int> t_estimation = Task.Factory.StartNew(() => { return random.Next(1, 20); });
                Task[] tasks = { t_taskId, t_difficulty, t_estimation };
                Task.WaitAll(tasks);
                 tasksList.Add(new Tasks() { TaskId =t_taskId.Result, Difficulty =t_difficulty.Result , Estimation = t_estimation.Result, TaskName = NameGenerator() }); //task.TaskId= random.Next(0, 22));
            }
            return tasksList;

        }
        public static string NameGenerator() {
            int nameLength = 8;
           // Random randomValue = new Random();
            int[] randomValuesList=new int[nameLength];
            StringBuilder name = new StringBuilder();
            string[] a = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Random randomValue = new Random(Guid.NewGuid().GetHashCode());
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
