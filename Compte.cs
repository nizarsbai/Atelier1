using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1
{
    class Compte
    {
        private static int cmp = 0;
        private readonly int numCompte;
        private readonly Client titulaire;
        private MAD solde;
        private static MAD plafond;

        //Constructeur
        public Compte(Client C, MAD solde)
        {
            cmp++;
            numCompte = cmp;
            titulaire = C;
            this.solde = solde;
        }

        public int NumCompte() { return this.numCompte; }
        public Client Titulaire() { return this.titulaire; }
        // public double Solde() {  return this.solde;  }


        //Methodes
        public void Crediter(MAD montant)
        {
            if (montant.Sup(new MAD(0)))
            {
                this.solde.Plus(montant);
            }
            else
            {
                Console.WriteLine("Vous devez crediter un montant positif au compte souhaite");
            }
        }
        public bool Debiter(MAD montant)
        {
            if (montant.Sup(new MAD(0)))
            {
                this.solde-=montant;
                return true;
            }
            else
            {
                Console.WriteLine("Vous devez debiter un montant positif au compte souhaite");
                return false;
            }
        }
        public void retirer(MAD montant)
        {
            if (montant.Sup(plafond) != true && montant.Sup(new MAD(0)))
                solde -= montant;
            else
                Console.WriteLine("Vous devez debiter un montant positif au compte souhaite");
        }
        public void verser(MAD montant, Compte C)
        {
           if( this.Debiter(montant))
                     C.Crediter(montant);
            // this.solde -= montant;
            // C.solde += montant;

        }
        public void afficher()
        {
            Console.WriteLine("Numero de compte :" + numCompte + "\nTitulaire : ");
            this.titulaire.afficher();
            this.solde.print();
        }

    } }


