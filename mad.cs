using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class mad
    {
        private double valeur;

        public void afficher()
        {
            Console.Out.WriteLine("valeur: " + valeur);
        }
        public mad(double valeur)
        {
            this.valeur = valeur;
        }
        public static mad operator+(mad c1,mad c2)
        {
            mad c3 = new mad(c1.valeur + c2.valeur);
            return c3;
        }
        public static mad operator-(mad c1, mad c2)
        {
            mad c4 = new mad(c1.valeur - c2.valeur);
            return c4;
        }
        public static bool operator >=(mad c1, mad c2)
        {
            return (c1.valeur >= c2.valeur);

        }
        public static bool operator <=(mad c1, mad c2)
        {
            return (c1.valeur <= c2.valeur);

        }


    }
}