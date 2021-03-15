using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Client C1 = new Client("Sbai", "Nizar", "Oulfa");
            Client C2 = new Client("BENCHEKROUN", "Youssef", "Ain-chock");

           // Compte t = new Compte(C, 100);
            

            MAD solde1 = new MAD(230000);
            MAD solde2 = new MAD(333000);

            Compte Cp1 = new Compte(C1, solde1);
            Compte Cp2 = new Compte(C2, solde2);

            C1.afficher();
            C2.afficher();
            MAD solde4 = new MAD(43000);
            MAD solde5 = new MAD(78000);
            MAD solde6 = new MAD(88000);
            Cp1.Crediter(solde4);
           // Console.WriteLine("Solde apres credit du compte 1 : " + C1.Solde);
            Cp1.verser(solde5, Cp2);
           // Console.WriteLine("Solde apres virement du compte 1 :" + Cp1.solde);
            Cp2.Debiter(solde6);

            Cp1.afficher();
            Cp2.afficher();
           // Console.WriteLine("Solde apres debit du compte 2 :" + C2.Solde);

 

            Console.ReadKey();

        }
    }
}
