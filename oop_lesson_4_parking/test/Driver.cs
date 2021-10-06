using oop_lesson_4_parking.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.test
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }

        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.listOfCustomers.Add(new Customer("A",2));
            carpark.listOfCustomers.Add(new Customer("B",3));
            carpark.listOfCustomers.Add(new Customer("C",4));
            carpark.listOfCustomers.Add(new Customer("D",5));
            carpark.listOfCustomers.Add(new Customer("E",6));
            carpark.listOfCustomers.Add(new Customer("F",7));

            carpark.CalculateCarges();

            Customer customer = new Customer("G",8);
            CarParkCharge carparkcharge = new CarParkCharge();

            //call the ToString Method

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());
        }
    }
}
