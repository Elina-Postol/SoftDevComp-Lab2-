using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTrackingActivities {
   public class User {
        private static User instance;
        private User (){}
        public static User Instance { get {
                if(instance == null) {
                    instance =new User();
                }
                return instance;
            } }

    }
}
