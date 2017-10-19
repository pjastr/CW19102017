using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Samochod
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double cena;

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public string Marka { get; set; }

        public double pojemnosc;
        
    }
}
