using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Program
    {
        public static BaseClass[] staff = new BaseClass[10];
        
        /// <summary>
        /// метод заполнения массива сотрудников
        /// </summary>
        public static void LoadStaff()
        {
            for (int i = 0; i < staff.Length; i++)
            {
                staff[i] = new Fixed();
            }
        }

        static void Main(string[] args)
        {
            LoadStaff();
            Staff.CreateStaff();
            Fixed fix = new Fixed();
            fix.Wage();
            Hourly hourly = new Hourly();
            hourly.Wage();
            Console.WriteLine("Фиксированная ЗП = " + fix.resault);
            Console.WriteLine("Повременная ЗП = " + hourly.resault);
            Console.ReadLine();
        }
    }
}
//Надеюсь хоть что-то сделал правильно...
//Не понял как прикрутить какого типа ЗП у сотрудника. (Станислав Пономарев, 29, фиксированная ЗП 35000)
//Не смог сдлеать задание c.* Реализовать интерфейсы для возможности сортировки массива, используя Array.Sort();
