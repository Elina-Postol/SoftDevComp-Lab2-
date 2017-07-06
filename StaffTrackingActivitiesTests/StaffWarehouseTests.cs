using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaffTrackingActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities.Tests {
    [TestClass()]
    public class StaffWarehouseTests {
        [TestMethod()]
        public void CompareDevelopersCorrectWorkTest() {
            StaffWarehouse staff = new StaffWarehouse();
            List<Developer> developers = new List<Developer>();
            int salary = 1500;
            string proficiency = "middle";
            bool wrongProficiency = true;
            bool wrongSalary = true;
            int wrong = 0;
            developers = staff.CompareDevelopers(proficiency, salary);
            for (int i = 0; i < developers.Count(); i++) {
                wrongProficiency = developers.ElementAt(i).Proficiency != proficiency;
                wrongSalary = developers.ElementAt(i).Salary > salary;
                if (wrongProficiency ^ wrongSalary) {
                    wrong++;
                }
            }
            Assert.AreEqual(0, wrong);

        }

    }

}