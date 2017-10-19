using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Matematyka
    {
        private static double pi = 3.14;

        public static double OdwodKola(int r)
        {
            return 2 * Matematyka.pi * 4;
        }

        public static double PoleKola(int r)
        {
            return pi * r *r;
        }


    }
}
