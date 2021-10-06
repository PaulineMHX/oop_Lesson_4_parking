using oop_lesson_4_parking.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            driver.CreateObjects();

            Console.ReadKey();

        }
    }
}
