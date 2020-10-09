using System;
using System.Collections.Generic;
using System.Linq;


//L'affichage n'est pas assez bon mais c'est la fonctionnalité qui m'intéressait :-)

namespace Pendu_Game
{
    class Program
    {
        // Voir si le mot existe
        static bool IsWord(string mot_secret, List<string> mot_a_deviner)
        {

            bool word = false;

            for (int i = 0; i < mot_secret.Length; i++)
            {
                string wordIndex = Convert.ToString(mot_secret[i]);

                if (mot_a_deviner.Contains(wordIndex))
                {
                    word = true;
                }
                else
                {
                    return word = false;
                }

            }
            return word;
        }

        //Verif de la lettre
        static string IsGoodLetter(string motSecret, List<string> lettreDeviner)
        {
            string letterCorrect = "";
            for (int i = 0; i < motSecret.Length; i++)
            {
                string c = Convert.ToString(motSecret[i]);

                if (lettreDeviner.Contains(c))
                {
                    letterCorrect += c;
                }
                else
                {
                    letterCorrect += "*";
                }

            }
            return letterCorrect;
        }

        static void Main()
        {
            Console.Title= "Pendu Game by Alex";
            Console.WriteLine("Bienvenue dans le jeu de Pendu");
            Console.WriteLine("Règles:\n\t1- Vous devez deviner un mot choisit par l'ordinateur " +
                "\n\t2- Il vous seras demandez à chaque d'entrez une lettre" +
                "\n\t3- Si la lettre que vous entrez se trouve dans le mot caché alors vous le verrai apparaitre peu à peu" +
                "\nNB : Mais attention vous n'avez que 10 chances :-)");

            Console.WriteLine("\n");
            Console.WriteLine("Ready Go!!!\n");
            //Liste des Mots
            List<string> wordsList = new List<string> {
                "ANANAS",
                "AMOUR",
                "HAINE",
                "SOLITUDE",
                "REGRET",
                "PASSION",
                "ORANGE",
                "VOITURE",
                "EXPLORATION",
                "VIOLATION",
                "OEUF",
                "GARBA",
                "IGNAME",
                "CONSTITUTIONNEL",
                "MAUVAIS"
            };

            Random rnd = new Random();
            int listIndex = rnd.Next(wordsList.Count);//Renvoie un index aléatoire qu'on utiliseras pour recupérer le mot

            string motSecret = wordsList[listIndex];
            List<string> lettreDeviner = new List<string>();

            //Console.WriteLine(motSecret);

            int nbreCoups = 10;

            Console.WriteLine("Tentez de trouver le mot caché :-)");
            Console.WriteLine("Le mot caché contient {0} lettres", motSecret.Length);
            Console.WriteLine("N'oubliez pas vous n'avez que {0} chances", nbreCoups);
            Console.WriteLine("\n");
            IsGoodLetter(motSecret, lettreDeviner);
            while (nbreCoups > 0)
            {
               
                Console.Write("Entrez une lettre : ");
                string input = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");

                if (lettreDeviner.Contains(input))
                {
                    
                    Console.WriteLine("Vous avez déjà entrez la lettre {0}\nVeuillez entrez une autre", input);
                    Console.WriteLine("\n");
                    continue;
                }


                // if word found
                lettreDeviner.Add(input);
                if (IsWord(motSecret, lettreDeviner))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(motSecret);
                    Console.WriteLine("\n");
                    Console.WriteLine("\aFélicitations!!!");
                    break;
                }
                else if (motSecret.Contains(input))
                {
                    Console.WriteLine("\n");
                    
                    string letters = IsGoodLetter(motSecret, lettreDeviner);
                    Console.Write(letters);
                }
                else
                {
                    
                    Console.WriteLine("Echec, ce mot ne contient pas cette lettre");
                    nbreCoups -= 1;
                    Console.WriteLine("Il vous reste {0} coups", nbreCoups);
                }
                Console.WriteLine();

                if (nbreCoups == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game over \nLe mot est [ {0} ]", motSecret);
                    break;
                }

            }
            Console.WriteLine("Appuyez une touche pour quitter");
            Console.ReadKey();
        }
    }
}
