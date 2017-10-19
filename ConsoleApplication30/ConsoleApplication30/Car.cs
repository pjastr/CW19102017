using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        private Car()
        { 
        
        }
        private Car(double pojemnoscSilnika_s, string marka_s)
        {
            this.pojemnoscSilnika = pojemnoscSilnika_s;
            this.marka = marka_s;

        }

        public void dodajmarke(string marka_s)
        {
            this.marka = marka_s;
            //Console.WriteLine("Marka samochodu: {0}",marka);
        }

        public string Info()
        {
            return marka + " " + pojemnoscSilnika;
        }

        public override string ToString()
        {
            return marka + " " + pojemnoscSilnika;
        }

        public static Car Create(double poj, string marka)
        {
            Car temp = new Car(poj, marka);
            return temp;
        }

        public readonly static int iloscKol;

        public const int iloscDrzwi=4;

        static Car()
        {
            iloscKol = 4;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamiec");
            Console.ReadKey();
        }
    }
}
