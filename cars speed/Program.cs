using cars_speed.Models;

namespace cars_speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            Porsche s = new Porsche("Taycan GTS");
            do
            {
                Console.WriteLine("1.Drive");
                Console.WriteLine("2.MaxSpeed");
                Console.WriteLine("3.Exit");

               

               /* Console.WriteLine(@"1. Drive
 2. MaxSpeed
 3. Exit");*/


                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        s.Drive();
                        break;
                    case 2:
                        s.Maxspeed();
                        break;
                    case 3:
                        isContinue = false;
                        break;
                }
               
            } while (isContinue);
            Console.Clear();
            Console.WriteLine(s.Battery);
        }
    }
}
