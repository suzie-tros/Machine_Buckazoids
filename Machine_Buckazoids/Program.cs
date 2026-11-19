using System.ComponentModel.Design;

namespace Machine_Buckazoids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symboles = { "Fusée", "Alien", "Planète", "Comète", "Robot", "Étoile" };
            int[] rouleaux = new int[3];
            Random alea = new Random();
            const int JACKPOT_DEPART = 100;
            int jackpot = JACKPOT_DEPART;
            int buckazoids = 20;
            int credits = 0;
            int choix;


            for (int i = 0; i < rouleaux.Length; i++)
            {
                rouleaux[i] = alea.Next(0, symboles.Length);
            }
            Console.WriteLine("--------------------------------------------");
            Console.Write("|");
            for (int i = 0; i < rouleaux.Length; i++)
            {
                Console.Write(" {0} |", symboles[rouleaux[i]]);
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("votre choix : {0}", symboles[rouleaux[0]]);



            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Machine à buckazoids");
                Console.WriteLine("--------------------");
                Console.WriteLine("Montant du jackpot : {0}", jackpot);
                Console.WriteLine("Buckazoids : {0}", buckazoids);
                Console.WriteLine("Crédits : {0}", credits);
                Console.WriteLine("1 - Insérer une pièce");
                Console.WriteLine("2 - Jouer");
                Console.WriteLine("3 - Quitter");
                Console.Write("Votre choix : ");
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {
                    if (buckazoids > 0)
                    {
                        buckazoids = buckazoids - 1;
                        credits = credits + 1;
                        jackpot = jackpot + 1;
                    }
                    else
                    {
                        Console.WriteLine("Plus de buckazoids en poche !");
                    }
                }

            } while (choix != 3);

            Console.WriteLine("Vous quittez le bar avec {0} buckazoids.", buckazoids);
        
        

                else if (choix == 2)
            {
                if (credits == 0)
                {
                    Console.WriteLine("Insérer d’abord une pièce.");
                }
                else
                {
                    credits = credits - 1;
                    for (int i = 0; i < rouleaux.Length; i++)
                    {
                        rouleaux[i] = alea.Next(0, symboles.Length);
                    }
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("|");
                    for (int i = 0; i < rouleaux.Length; i++)
                    {
                        Console.Write(" {0} |", symboles[rouleaux[i]]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------");

                    if (rouleaux[0] == rouleaux[1] && rouleaux[1] == rouleaux[2])
                    {
                        Console.WriteLine("JACKPOT ! Vous gagnez {0} buckazoids !", jackpot);
                        buckazoids = buckazoids + jackpot;
                        jackpot = JACKPOT_DEPART;
                    }
                    else
                    {
                        Console.WriteLine("Perdu !");
                    }
                }
            }

            if (choix == 2)
            {
                if (credits > 0)
                {
                    credits = credits - 1;
                    for (int i = 0; i < rouleaux.Length; i++)
                    {
                        rouleaux[i] = alea.Next(0, symboles.Length);
                    }
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("|");
                    for (int i = 0; i < rouleaux.Length; i++)
                    {
                        Console.Write(" {0} |", symboles[rouleaux[i]]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------");
                    if (rouleaux[0] == rouleaux[1] && rouleaux[1] == rouleaux[2])
                    {
                        Console.WriteLine("Jackpot ! Vous gagnez {0} buckazoids !", jackpot);
                        buckazoids = buckazoids + jackpot;
                        jackpot = JACKPOT_DEPART;
                    }
                    else
                    {
                        Console.WriteLine("Perdu !");

                        if (credits == 0)
                        {
                            Console.WriteLine("Plus de crédits !");

                        }
                    }
                }
            }
        }
    }
}



    








