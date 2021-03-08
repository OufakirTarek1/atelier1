using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            compte c1 = new compte(new client("hamza", "alaoui", "ain chouk"), new mad(4000));
            c1.consulter();

            c1.crediter(new mad(6000));
            c1.consulter();

            c1.Debiter(new mad(2000));
            c1.consulter();

            compte c2 = new compte(new client("tarek", "oufakir", "habous"), new mad(3000));
            c2.verser(c1, new mad(2000));
            c1.consulter();
            c2.consulter();
            Console.Read();
        }
    }
}
