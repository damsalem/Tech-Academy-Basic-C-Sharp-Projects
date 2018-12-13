using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Legacy Hotel & Casino";
            Console.WriteLine("Welcome to the {0}. Let's start by you telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + "|");
                    Console.Write(exception.ExceptionType + "|");
                    Console.Write(exception.ExceptionMessage + "|");
                    Console.Write(exception.TimeStamp);
                    Console.WriteLine();
                }
                Console.ReadLine();
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

            Console.WriteLine("\nHello, {0}. Would you like to join a game of 21?", playerName);
            bool wannaPlay = false;
            while (!wannaPlay)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "ok" || answer == "okay" || answer == "sure" || answer == "yeah" || answer == "y" || answer == "yep" || answer == "yup" || answer == "ya" || answer == "true")
                {
                    wannaPlay = true;
                    Player player = new Player(playerName, bank);
                    player.Id = Guid.NewGuid();
                    using (StreamWriter file = new StreamWriter(@"C:\Users\Dani\Desktop\Basic-C#\TwentyOneGame\logs.txt", true))
                    {
                        file.WriteLine(player.Id);
                    }
                    Game game = new TwentyOne();
                    game += player;
                    player.isActivelyPlaying = true;
                    while (player.isActivelyPlaying && player.Balance > 0)
                    {
                        try
                        {
                            game.Play();
                        }
                        catch (FraudException ex)
                        {
                            Console.WriteLine(ex.Message);
                            UpdateDbWithException(ex);
                            Console.ReadLine();
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred. Please contact your System Administrator");
                            UpdateDbWithException(ex);
                            Console.ReadLine();
                            return;
                        }
                    }
                    game -= player;
                    Console.WriteLine("It looks like you're out. Thank you for playing at the {0}.", casinoName);
                }
                else if(answer == "no" || answer == "nope" || answer == "nah" || answer == "fuck you" || answer == "false")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I didn't understand. Do you want to play?");
                }
            }
            Console.WriteLine("Feel free to look around the casino {0}. Bye for now!", playerName);
            Console.ReadLine();
        }
        
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);
                
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            string query = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

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
            return Exceptions;
        }
    }
}
