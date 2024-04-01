using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_speed.Models
{
    internal class Porsche : ElectricCar
    {
        public string Model { get; }
        public const string Test = "abc";
       
        public Porsche(string model)
        {
            Model = model ;
        }
        public void Maxspeed()
        { 
            switch(Battery)
            {
                case > 90:
                    Console.WriteLine("Max speed is 350");
                    break;
                case > 75:
                    Console.WriteLine("Max speed is 300");
                    break;
                case > 50:
                    Console.WriteLine("Max speed is 250");
                    break;
                case > 30:
                    Console.WriteLine("Max speed is 200");
                    break;
                case > 10:
                    Console.WriteLine("Max speed is 100");
                    break;
            }
        }
        public void Drive()
        {
            Random r = new Random();
            int usedBattery = r.Next(20);
            Battery -= usedBattery;
            Console.WriteLine($"Driver used {usedBattery}% battery. Battery : {Battery}");

        }

    }
}
