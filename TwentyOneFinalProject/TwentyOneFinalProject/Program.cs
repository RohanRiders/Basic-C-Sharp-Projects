using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //this will allow you to work with ingesting files. 
using Casino;
using Casino.TwentyOneFinalProject;
using System.Data.SqlClient;
using System.Data;

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

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

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
                    catch (FruadException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator");
                        UpdateDbWithException(ex);
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

        private static void UpdateDbWithException(Exception ex) //You don't enter values for the coloumn headers because they will come in as varibles when the exception is triggered.
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneFinalProject;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO EXCEPTIONS (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //Paramartized Queries are what you need to prevent SQL injection.
                                                                                     //ADO.NET will help map parameters to these values, they will be substituted. 

            using (SqlConnection connection = new SqlConnection(connectionString))  //This is a special using statement that manages outside resource memory (i.e., Database, File Explorer, etc.)
            {
                SqlCommand command = new SqlCommand(queryString, connection);          
                //First we need to add the datatyype to the sql table. By specifying the datatype you are protecting against SqL Injection.
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                //Here are the values we will be adding to the Database table. 
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString(); //Here you are grabbing the data type. 
                command.Parameters["@ExceptionMessage"].Value = ex.Message; //This is the message of the exception that is a string. 
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open(); //Here is where we open the connection.
                command.ExecuteNonQuery(); //Here is where we execute the command. 
                connection.Close(); //Here is where we close the connection. 

            }   
            
        }

        //reading data objects from the db and converting into C#
        private static List<ExceptionEntity> ReadExceptions() 
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneFinalProject;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions; //We are returning a list of exception entities.
        }
    }
}
