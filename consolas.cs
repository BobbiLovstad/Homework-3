using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//Written By Bobbi Lovstad
//2/16/25

namespace Homework3_CIS122
{
    public class BossBattle
    {
        public static void Main(string[]args)
        {
            // Game Setup
            int cityHealth = 15;
            int maniCoreHealth = 10;
            int round = 1;

            // Get the Starting Distance
            int range = NumInRange("How far away do you want the manicore?", 0, 100);
            Console.Clear();

            Console.WriteLine("Player 2 Turn");

            // Loop until city or manicore is destroyed
            while (cityHealth > 0 && maniCoreHealth > 0)
            {
                //Display round status
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------");
                DisplayStatus(round, maniCoreHealth, cityHealth);

                //Display expected damage
                int damage = RoundDamage(round);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The cannon will deal {damage} damage this round");

                // Get the number from the player
                Console.ForegroundColor = ConsoleColor.Blue;
                int targetRange = AskForNumber("Enter a cannon Range");

                //Outcome of the number
                Console.ForegroundColor = ConsoleColor.Magenta;
                OverOrUnder(targetRange, range);

                //Damage to Manicore
                if (targetRange == range) maniCoreHealth -= damage;

                //Damage to city
                if (maniCoreHealth > 0) cityHealth--;

                // Next Round
                round++;
            }
            // Game Outcome
            bool won = cityHealth > 0;
            outcome(won);

            void outcome(bool won)
            {
                if (won)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Manicore is dead, city is saved");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("City has been defeated,Manicore wins")

                }

            }

            // Tells Player about target 
            void OverOrUnder (int targetRange, int range)
            {
                if (targetRange < range) Console.WriteLine("Round fell short of target");
                else if (targetRange > range) Console.WriteLine("Round Overshot Target");
                else Console.WriteLine("Direct Hit");
            }

            // Game Status
            void DisplayStatus(int round, int cityHealth, int maniCoreHealth) =>
                Console.WriteLine($"STATUS: round {round}: city {cityHealth}/15: manicore{maniCoreHealth}/10 ");

            int DamageForRound(int roundNumber)
            {
                if (roundNumber % 5 == 0 && roundNumber % 3 == 0) return 10; // Electric and Fire
                else if (roundNumber % 5 == 0) return 3; // electric
                else if (roundNumber % 3 == 0) return 3; //fire
                return 1; //normal
            }
            // gets number for user, asking the prompt supplied by text
            int AskForNumber(string text)
            {
                Console.Write(text + "");
                Console.ForegroundColor = ConsoleColor.Cyan;
                int number = Convert.ToInt32(Console.ReadLine());
                return number;


            }
            //Ensure user input is in range
            int NumInRange(string text, int min, int max)
            {
                while(true)
                {
                    int number = AskForNumber(text);
                    if (number >= min && number < max)
                        return number;
                }
            }
                    


                

        }
    }
}
