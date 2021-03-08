using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class compte
    {
        private int numcomp;
        private static int cpt = 0;
        private client titulaire;
        private mad solde;
        private static mad plafond = new mad(40000);

        public compte(client titulaire,mad solde)
        {
            cpt++;
            this.numcomp = cpt;
            this.solde = solde;
            this.titulaire = titulaire;
        }
        public bool crediter(mad somme)
        {
            if (plafond >= somme)
            {
                solde += somme;
                Console.Out.WriteLine("operation est realisee");
                return true;
            }
            else
                Console.Out.WriteLine("vous avez depasser le plafond");
                return false;    
        }

        public bool Debiter(mad somme)
        {
            if (plafond >= somme)
            {
                solde -= somme;
                Console.Out.WriteLine("operation est realisee");
                return true;
            }
            else
                Console.Out.WriteLine("vous avez depasse le plafond");
                return false;
        }
        public bool verser(compte c,mad somme)
        {
            if (solde >= somme)
        {
                solde -= somme;
                c.solde += somme;
                Console.Out.WriteLine("operation est realisee");
                return true;
        }
            else
                Console.Out.WriteLine("le solde est insuffisant");
                return false;

        }
        public void consulter()
        {
            Console.Out.WriteLine("Numéro de Compte: " + numcomp);
            Console.Out.WriteLine("titulaire du compte est : ");
            titulaire.print();
            Console.Out.WriteLine("Solde de compte: ");
            solde.afficher();
            Console.Out.WriteLine();
        }
    }
}
