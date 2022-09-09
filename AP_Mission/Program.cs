using System;
using System.Collections.Generic;
using System.Text;
using AP_Mission;
class Program
{
    static void Main()
    {

        Compte c2, c1;
        c1 = new Compte(12345, "toto", 1000, -500);
        c2 = new Compte(45657, "titi", 2000, -1000);
        c1.transferer(1000, c2);
        c1.Afficher();
        c2.Afficher();
        c1.Superieur(c1, c2);
    }
}