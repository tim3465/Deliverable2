// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        int Correct = 0;

        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string Name = Console.ReadLine();
        int Did = 0;
        do
        { Console.WriteLine("Welcome " + Name + " Do you want to do the COIN FLIP CHALLENGE? Yes/No ");
            string Anser = Console.ReadLine();

            //Yes or no choice 
            if (Anser == "No" || Anser == "no")
            { Console.WriteLine("You are a coward " + Name);
                Did = 1;
            }
            else if (Anser == "Yes" || Anser == "yes")
            { Console.WriteLine("");
                Did = 1;

                //Heads or tails loop 
                for (int i = 0; i < 5; i++)
                {
                   
                    // Random generator;
                    Random Coin = new Random();
                    int did = 0;
                    do
                    {int Face = Coin.Next(2);

                        // Choise 
                        Console.WriteLine("Heads or Tails?");
   //*******************Console.WriteLine(Face);
                        string Choice = Console.ReadLine();

                        //True Answer 1=Heads 0=Tails
                        if ((Choice == "Heads" && Face == 1)  || (Choice == "Tails" && Face == 0))
                        { Console.WriteLine("Correct!!");
                            Console.WriteLine("");
                            Correct += 1;
                            did = 1;
                        }

                        //False Answer  
                        else if ((Choice == "Heads" && Face == 0)  || (Choice == "Tails" && Face == 1) )
                        { Console.WriteLine("Wrong!");
                            Console.WriteLine("");
                            did = 1;
                        }
                        else
                        { Console.WriteLine("That wasn't an answer. Pase try again.");
                            Console.WriteLine("");
                            did = 0;
                        }
                    } while (did <= 0);
                }
            }
           else
            { Console.WriteLine("That wasn't an answer. Pase try again. ");
                Did = 0;
            }
        } while (Did == 0);
        Console.WriteLine("Thank you " + Name + ".You got a score of " + Correct + "!");
    }
}