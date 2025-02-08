using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O0PsConcept
{
    public class Car
    {
        // methhod
        public string Name { get; set; }
        public string BrandNName { get; set; }
        public int NoOfSeat { get; set; }

        //method
        public int Accelator(int pressure)
        {
            int speed = pressure * 10;
            return speed;
        }

        public int Brake(int pressure)
        {
            int speed = pressure / 10;
            return speed;
        }

        public int clush(int pressure)
        {
            int speed = pressure;
            return speed;
        }

        public void CurrentSpeed()
        {
            Console.WriteLine("Your Current Speed is:120kph");
        }

    }

}
