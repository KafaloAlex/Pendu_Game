using System;
using System.Collections.Generic;
using System.Linq;

namespace Pendu_Game
{
    class Program
    {
        //Récupération du mot saisi par le user
        static string recup_mot()
        {
            string user_mot;
            Console.Write("Entrez une lettre : ");
            Console.WriteLine("\n");
            user_mot = Console.ReadLine().ToUpper();

            while (user_mot.Length > 1)
            {
                Console.WriteLine("Tcher on dit une lettre maudit là \nReprend tout à zéro chien là");
                return recup_mot();
            }
            return user_mot;
        }

        //Récupération mot masqué
        static string recup_mot_étoiler(string randomMot, List<string> letter_find) //letter_find représente les lettres déjà trouvé
        {
            string mot_cache = "";
            foreach (var item in randomMot)
            {
                item.ToString();

                if (letter_find.Contains(item.ToString()))
                    mot_cache += item;
                else
                    mot_cache += "*";
            }

            return mot_cache;
        }

        static void Main(string[] args)
        {
            //Variables
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
            int listIndex = rnd.Next(wordsList.Count);//Renvoie l'index qu'on utiliseras pour recupérer le mot

            string mot_a_trouver = wordsList[listIndex];
            //string motUser = recup_mot();
            Console.WriteLine(mot_a_trouver);
            int nbreCoups = 0;


            List<string> letter_deja_find = new List<string>(); //Liste des lettres déjà trouvées 

            //var bingo = recup_mot_étoiler(mot_a_trouver, letter_deja_find);

            while (nbreCoups < 10)
            {
                string motUser = recup_mot();//Récupération du mot du user

                foreach (var item in letter_deja_find)
                {
                    item.ToString();

                    if (mot_a_trouver.Contains(item))
                    {
                        letter_deja_find.Add(item);
                    }
                    else
                    {
                        nbreCoups++;
                        Console.WriteLine("Cette lettre n'est pas dedans");
                    }
                }

                var bingo = recup_mot_étoiler(mot_a_trouver, letter_deja_find);

                if(bingo == mot_a_trouver)
                    Console.WriteLine("Bravo le mot était {0}", mot_a_trouver);
                else
                    Console.WriteLine("Vous avez perdu:-(");
            }



        }
    }
}
