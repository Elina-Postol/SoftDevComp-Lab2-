using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaffTrackingActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities.Tests {
    [TestClass()]
    public class FillerTasksTests {
        [TestMethod()]
        public void TaskGeneratorReturnsNotNullListTest() {
            HashSet<Tasks> tasks = new HashSet<Tasks>();
            tasks = FillerTasks.TaskGenerator();
            int actual = tasks.Count();

            Assert.IsNotNull(actual);
        }
        [TestMethod()]
        public void TaskGeneratorReturnsAllFieldsWithDataTest() {
            HashSet<Tasks> tasks = new HashSet<Tasks>();
            tasks = FillerTasks.TaskGenerator();
            bool difficulty = false;
            bool estimation = false;
            bool taskid = false;
            bool taskname = false;
            int wrong = 0;
            for (int i = 0; i < tasks.Count(); i++) {
                difficulty = tasks.ElementAt(i).Difficulty.Equals(0);
                estimation = tasks.ElementAt(i).Estimation.Equals(0);
                taskid = tasks.ElementAt(i).TaskId.Equals(0);
                taskname = tasks.ElementAt(i).TaskName.Equals(0);
                if (difficulty ^ estimation ^ taskid ^ taskname) {
                    wrong++;
                }
            }
            Assert.AreEqual(0, wrong);
        }


    }
}