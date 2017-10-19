using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car(140, "Honda");
            //Console.WriteLine(c1);

            //Car c2 = new Car();
            //c2.dodajmarke("Mercedes");

            Car auto = Car.Create(233, "Skoda");
            //Car.iloscDrzwi = 5;
            Car auto2 = Car.Create(323, "Ford");
            Console.WriteLine(Car.iloscKol);
        }
    }
}
