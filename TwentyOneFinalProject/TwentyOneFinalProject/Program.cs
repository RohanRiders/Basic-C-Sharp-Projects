﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //this will allow you to work with ingesting files. 
using Casino;
using Casino.TwentyOneFinalProject;


namespace TwentyOneFinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string casinoName = "Grand Casino Hotel!";
            //Guid identifier = Guid.NewGuid(); //Here is a way of using a guid
            //Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.");
            //var newDictionary = new Dictionary<string, string>();// this is an implicit way of adding variable types. In some cases you don't need to explicitly declare the data type. 
            //var newPlayer = new Player("Trason"); //Here you are using overloaded constrcutors. Notice the default value 100 is set for the player Remember to rebuild the project its referencing to bring in any changes. 

           

            //Here is the entry point to the program. 
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me  your name");
            string playerName = Console.ReadLine(); //They will then tell us their name. 

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. would you like to join a game of 21 right now?", playerName); //String entropolation: playerName will be placed in the {0} variable.
            string answer = Console.ReadLine().ToLower(); //Changing it to lower makes it easier for the computer to do an if statement on the response. 
            if (answer == "yes" || answer =="yeah" || answer == "y" || answer == "ya") //You don't need an Else in the instance because if they say 'no' it will skip this and run the last two lines. 
            {
                Player player = new Player(playerName, bank); //We immediately created a player object and were able to pass in the player's name and the money they plan to play with. 
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\trason.carver\Documents\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id); //Here is an example of posting a user GUID to a log file. 
                }             
                
                Game game = new TwentyOneGame(); //polymorphism is displayed here because we are creating TwentyOneGame but it is exposing the Game object properties and methods. 
                game += player; //This exposes those overloaded operators we made in the Player class. We are adding the player to the game. 
                player.isActivelyPlaying = true; //We set this in order to set up a While Loop for us below. While the player playing is true continue the loop. 
                while (player.isActivelyPlaying && player.Balance > 0) //While these two conditions are true run the Play() method. 
                {
                    try
                    {
                        game.Play(); //This method is defined in the game class object, you are simply calling it here. 
                    }
                    catch (FruadException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player; //remove the player from the game. 
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now."); 
            Console.ReadLine(); 
        }
    }
}
