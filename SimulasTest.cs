using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework3_CIS122
{
    //Written By Bobbi Lovstad
    //2/16/25
    public class SimulusTest
    {
        // define enumaration
        enum ChestState { Open, Closed, Locked } 
        public static void Main(string[]args)
        {
            // Variable type is new enumuration
            ChestState currentState = ChestState.Locked;

            //Forever While loop

            while(true)
            {
                Console.Write($" the chest is {currentState}. What would you like to do");

                string input = Console.ReadLine();

                if (currentState == ChestState.Locked && input == "unlock" currentState = ChestState.Closed;
                if (currentState == ChestState.Locked && input == "open"currentState = ChestState.Open;
                if (currentState == ChestState.Locked && input == "close" currentState = ChestState.Closed;
                if (currentState == ChestState.Locked && input == "lock" currentState = ChestState.Locked;

            }

           
    }
}
