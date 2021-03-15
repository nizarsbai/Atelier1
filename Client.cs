using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        
        public Client(string n,string p,string a)
        {
            nom = n;
            prenom = p;
            adresse = a;
        }
        public void afficher()
        {
            Console.WriteLine("Nom : "+nom);
            Console.WriteLine("Prenom : "+prenom);
            Console.WriteLine("Adresse : "+adresse);
        }
    }
}
