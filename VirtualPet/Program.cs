using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("There's a goldfish swimming over there! Do you want to it to be your pet? (Type 'no' to quit.)");
                string beginGame = Console.ReadLine();

                if (beginGame.ToLower() == "no")
                {
                    Console.WriteLine("Okay, see you later!");
                    Environment.Exit(0);
                }

                Console.WriteLine("What would you like to name the goldfish?");
                string goldfishName = Console.ReadLine();

                Goldfish myGoldfish = new Goldfish(goldfishName);

                Console.WriteLine("Great, we'll call it {0}! Let's see how {0} is doing.", goldfishName);
                Console.WriteLine(" ");

                bool isPlaying = true;
                while(isPlaying == true)
                {
                    myGoldfish.Status();
                    int userChoice = int.Parse(Console.ReadLine());

                    if (userChoice == 1)
                    {
                        myGoldfish.Feed();
                    }

                    else if (userChoice == 2)
                    {
                        myGoldfish.CleanWater();
                    }

                    else if (userChoice == 3)
                    {
                        myGoldfish.Watch();
                    }

                    else if (userChoice == 4)
                    {
                        myGoldfish.Catch();
                    }

                    else if (userChoice == 5)
                    {
                        Console.WriteLine("Okay, see you later!");
                        isPlaying = false;
                    }

                    else
                    {
                        Console.WriteLine("That's not a valid option. Please choose a number!");
                    }

                }

            }
        }
    }
}
