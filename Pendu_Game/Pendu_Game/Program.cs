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

            while(user_mot.Length > 1)
            {
                Console.WriteLine("Tcher on dit une lettre maudit là \nReprend tout à zéro chien là");
                return recup_mot();
            }
            return user_mot;
        }

        //Récupération mot masqué
        static string recup_mot_étoile(string randomMot, string letter_find) //letter_find représente les lettres déjà trouvé
        {
            string mot_cache = "";
            for (int i = 0; i < randomMot.Length; i++)
            {
                if()
            }
            /*mot_masque = ""
    for lettre in mot_complet:
        if lettre in lettres_trouvees:
            mot_masque += lettre
        else:
            mot_masque += "*"
    return mot_masque*/
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
            //var size = mot_a_trouver.Length;
            List<string> valid_words = new List<string>();

            /*bool isValid = true; //Savoir si le joueur est toujours là
            char userEntry;

            Console.WriteLine("Essayez de trouver le mot:-)");
            Console.WriteLine("Voici le mot::: {0}", mot_a_trouver);

            while (isValid)
            {
                Console.Write(" Entrez une lettre : ");
                userEntry =Convert.ToChar(Console.ReadLine().ToUpper());

                for (int i = 0; i < mot_a_trouver.Length; i++)
                {
                   *//* char verif = mot_a_trouver[i];*//*
                    if(userEntry == mot_a_trouver[i])
                    {
                        valid_words.Add(userEntry);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }*/
        }

      
    }
}
