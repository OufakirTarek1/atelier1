using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class client
    {
        private string nom;
        private string prenom;
        private string adresse;
        public client(string nom, string prenom, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
        }
        public void print()
        {
            Console.Out.WriteLine("nom: " + nom);
            Console.Out.WriteLine("prenom: " + prenom);
            Console.Out.WriteLine("adresse: " + adresse);
        }

    }
}