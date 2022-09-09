using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_Mission
{
    public class Compte
    {
        private double numero;
        private string nom;
        private double solde;
        private double decouvertAutorise;

        public Compte()
        {
            this.numero = 0;
            this.nom = "";
            this.solde = 0;
            this.decouvertAutorise = 0;
        }
        public Compte(double numero, string nom, double solde, double decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertAutorise = decouvertAutorise;
        }
        public double Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public double Solde
        {
            get { return this.solde; }
            set { this.solde = value; }
        }
        public double DecouvertAutorise
        {
            get { return this.decouvertAutorise; }
            set { this.decouvertAutorise = value; }
        }
        public void Afficher()
        {
         Console.WriteLine("numero: "+this.numero+" nom: "+this.nom+" solde "+this.solde+" découvert autorisé: "+this.decouvertAutorise);
          
        }
        public void crediter(double crediter)
        {
            this.solde = this.solde+crediter;
        }
        public void debiter(double debiter)
        {
            this.solde = this.solde - debiter;
        }
        public void transferer(double transfert,Compte tr)
        {
            debiter(transfert) ;
            tr.crediter(transfert);
        }
        public void Superieur(Compte c1,Compte c2)
        {
            if (c1.solde > c2.solde)
            {
                Console.WriteLine("Le premier compte à un solde supérieur au second compte"); 
               
            }
            else
            {
                Console.WriteLine("Le premier compte à un solde inférieur au second compte");
            }
        }
    }
}
