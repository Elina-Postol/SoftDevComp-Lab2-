using StaffTrackingActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
    /// <summary>
    /// A general class for a company that include array of developers, QA, managers
    /// </summary>
    public class StaffWarehouse : SystemUser {
       
        SystemUser systemUser = new SystemUser();
        List<Developer> developer = new List<Developer>();
        public List<QA> testingEngineer = new List<QA>();
        public List<Developer> DevelopersList() {
            developer.Add(new Developer() { DeveloperId = 1, FirstName = "Dev1", LastName = "Developer1", Salary = 1000, JobPosition = "Developer", Proficiency = "junior" });
            developer.Add(new Developer() { DeveloperId = 2, FirstName = "Dev2", LastName = "Developer2", Salary = 1100, JobPosition = "Developer", Proficiency = "junior" });
            developer.Add(new Developer() { DeveloperId = 3, FirstName = "Dev3", LastName = "Developer3", Salary = 1650, JobPosition = "Developer", Proficiency = "middle" });
            developer.Add(new Developer() { DeveloperId = 4, FirstName = "Dev4", LastName = "Developer4", Salary = 1200, JobPosition = "Developer", Proficiency = "middle" });
            developer.Add(new Developer() { DeveloperId = 5, FirstName = "Dev5", LastName = "Developer5", Salary = 1540, JobPosition = "Developer", Proficiency = "middle" });
            developer.Add(new Developer() { DeveloperId = 6, FirstName = "Dev6", LastName = "Developer6", Salary = 1200, JobPosition = "Developer", Proficiency = "middle" });
            developer.Add(new Developer() { DeveloperId = 7, FirstName = "Dev7", LastName = "Developer7", Salary = 1400, JobPosition = "Developer", Proficiency = "middle" });
            developer.Add(new Developer() { DeveloperId = 8, FirstName = "Dev8", LastName = "Developer8", Salary = 1100, JobPosition = "Developer", Proficiency = "middle" });
            developer.Add(new Developer() { DeveloperId = 9, FirstName = "Dev9", LastName = "Developer9", Salary = 1990, JobPosition = "Developer", Proficiency = "senior" });
            developer.Add(new Developer() { DeveloperId = 10, FirstName = "Dev10", LastName = "Developer10", Salary = 1900, JobPosition = "Developer", Proficiency = "senior" });
            return developer;
        }
        public List<QA> QAList() {
            testingEngineer.Add(new QA() { QAId = 1, FirstName = " QA1", LastName = "TestEngineer1", Proficiency = "junior", JobPosition = "QA", Salary = 980 });
            testingEngineer.Add(new QA() { QAId = 2, FirstName = " QA2", LastName = "TestEngineer2", Proficiency = "senior", JobPosition = "QA", Salary = 1390 });
            testingEngineer.Add(new QA() { QAId = 3, FirstName = " QA3", LastName = "TestEngineer3", Proficiency = "junior", JobPosition = "QA", Salary = 980 });
            testingEngineer.Add(new QA() { QAId = 4, FirstName = " QA4", LastName = "TestEngineer4", Proficiency = "middle", JobPosition = "QA", Salary = 1080 });
            testingEngineer.Add(new QA() { QAId = 5, FirstName = " QA5", LastName = "TestEngineer5", Proficiency = "junior", JobPosition = "QA", Salary = 980 });
            testingEngineer.Add(new QA() { QAId = 6, FirstName = " QA6", LastName = "TestEngineer6", Proficiency = "middle", JobPosition = "QA", Salary = 1110 });
            testingEngineer.Add(new QA() { QAId = 7, FirstName = " QA7", LastName = "TestEngineer7", Proficiency = "junior", JobPosition = "QA", Salary = 980 });
            testingEngineer.Add(new QA() { QAId = 8, FirstName = " QA8", LastName = "TestEngineer8", Proficiency = "middle", JobPosition = "QA", Salary = 1120 });
            testingEngineer.Add(new QA() { QAId = 9, FirstName = " QA9", LastName = "TestEngineer9", Proficiency = "senior", JobPosition = "QA", Salary = 1480 });
            testingEngineer.Add(new QA() { QAId = 10, FirstName = " QA10", LastName = "TestEngineer10", Proficiency = "senior", JobPosition = "QA", Salary = 1440 });
            return testingEngineer;
        }

        public List<Developer> CompareDevelopers(string proficiencySelected, int salary) {
            Developer developerCompare = new Developer();
            List<Developer> devList = DevelopersList();
            List<Developer> compareList = new List<Developer>();
            List<Developer> compareWithList = new List<Developer>();

            compareWithList.Add(new Developer() { DeveloperId = 999, FirstName = "Dev999", LastName = "Developer99", Salary = salary, JobPosition = "Developer", Proficiency = proficiencySelected });

            devList = developer.FindAll(d => d.Proficiency.Contains(proficiencySelected));
            for (int i = 0; i < devList.Count(); i++) {

                int result = developerCompare.CompareTo(devList.ElementAt(i), compareWithList.ElementAt(compareWithList.Count()-1));

                if (result < 0) {
                    devList.ElementAt(i).Order = 1;
                    compareList.Add(devList.ElementAt(i));
                   
                } else if (result == 0) {
                    compareList.Add(devList.ElementAt(i));
            

 }
                }
            
                return compareList;

           
        }
        public void CompareQA() {

            List<QA> compareQA = QAList();
            QA qa = new QA();
            for (int i = 0; i < compareQA.Count; i++) {
                int result = qa.CompareTo(testingEngineer.ElementAt(i), testingEngineer.ElementAt(1));
                if (result == 0) Console.WriteLine("{0,12}={1}", testingEngineer.ElementAt(i).Proficiency, testingEngineer.ElementAt(1).Proficiency);
                else if (result > 0) Console.WriteLine("{0,12}>{1}", testingEngineer.ElementAt(i).Proficiency, testingEngineer.ElementAt(1).Proficiency);
                else Console.WriteLine("{0,12}<{1}", testingEngineer.ElementAt(i).Proficiency, testingEngineer.ElementAt(1).Proficiency);
            }
        }

       
    }
}

