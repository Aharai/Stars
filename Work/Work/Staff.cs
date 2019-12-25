using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Staff : Fixed
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public static void CreateStaff()
        {
            
            Staff[] staff = new Staff[3];

            staff[0] = new Staff() { FirstName = "Станислав", LastName = "Пономарев", Age = 29 };
            staff[1] = new Staff() { FirstName = "Павел", LastName = "Фадеев", Age = 32 };
            staff[2] = new Staff() { FirstName = "Владимир", LastName = "Змиевский", Age = 34 };

            foreach(var x in staff)
            {
                Console.WriteLine("Сотрудник: {0} {1}, {2} ", x.FirstName, x.LastName, x.Age);
            }
            
        }
    }
}
