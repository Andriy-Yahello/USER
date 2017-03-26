using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class Program
    {
        
        static void Main()
        {
            User user = new User();
            user.Show();

            User user2 = new User("lofongi", "Big", "Rock", 27);
            user2.Show();

            Console.ReadKey();
        }


    }
}
