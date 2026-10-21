using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Application "Denombrements".
        /// Permet à l'utilisateur de tester des calculs de permutations, d'arrangements ou de combinaisons, avec un affichage géré.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choix = 1;

            //Affichage et saisie du choix avec controle de saisie et traitements différents selon le choix
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) { Environment.Exit(0); }

                //choix de la permutation
                if (choix == 1)
                {
                    Console.Write("nombre total d'éléments à gérer = ");
                    int nombreTotal = int.Parse(Console.ReadLine());
                    long resultat = 1;
                    for (int k = 1; k <= nombreTotal; k++)
                        resultat *= k;
                    Console.WriteLine(nombreTotal + "! = " + resultat);
                }
                else
                {
                    //choix de l'arrangement
                    if (choix == 2)
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nombreTotal = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int nombreSousEnsemble = int.Parse(Console.ReadLine());
                        long resultat = 1;
                        for (int k = (nombreTotal - nombreSousEnsemble + 1); k <= nombreTotal; k++)
                            resultat *= k;
                        Console.WriteLine("A(" + nombreTotal + "/" + nombreSousEnsemble + ") = " + resultat);
                    }
                    //choix de la combinaison
                    else
                    {
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nombreTotal = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int nombreSousEnsemble = int.Parse(Console.ReadLine());
                        long resultat1 = 1;
                        for (int k = (nombreTotal - nombreSousEnsemble + 1); k <= nombreTotal; k++)
                            resultat1 *= k;
                        long resultat2 = 1;
                        for (int k = 1; k <= nombreSousEnsemble; k++)
                            resultat2 *= k;
                        Console.WriteLine("C(" + nombreTotal + "/" + nombreSousEnsemble + ") = " + (resultat1 / resultat2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
