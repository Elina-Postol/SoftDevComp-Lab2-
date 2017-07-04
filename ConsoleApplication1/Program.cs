using StaffTrackingActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            StaffWarehouse stafflist = new StaffWarehouse();
            FillerTasks filler = new FillerTasks();
           
            foreach (var task in   FillerTasks.TaskGenerator()) {
                Console.WriteLine(task);
                 }
            string test="";
            stafflist.CompareQA();
            stafflist.CompareDevelopers(test, 1200);
            Console.ReadKey();
           
        }
    }
}
