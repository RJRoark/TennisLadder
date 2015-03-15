using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDatabase;

namespace DAL
{
    public class DAL
    {

        public static void Store(object data)
        {

            // Open the database
            using (var odb = OdbFactory.Open("test.db"))
            {
                // Store the object
                odb.Store(data);
            }
        }

        public static object GetPlayer()
        {
            using (var odb1 = OdbFactory.Open("test.db"))
            {
                var player = odb1.QueryAndExecute<object>();
                return player.First().ToString();
            }

           
        }
        
    }
}
