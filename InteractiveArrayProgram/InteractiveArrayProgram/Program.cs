using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /////
            ///Create a string array
            /////
            string[] stringArray = { "0) Avatar", "1) Austin Powers", "2) Officer and a Gentleman", "3) African Queen", "4) Ready Player One" };

            //Write text
            Console.WriteLine("Here is your movie selection:");
            ///Display entire array
            stringArray.ToList().ForEach(Console.WriteLine);

            //User enters values
            Console.WriteLine("Please enter a single value between 0-" + (stringArray.Length - 1) + " to display one of those strings.");
            ///Read entered text and convert to "i"
            int i = Convert.ToInt32(Console.ReadLine());

            bool movieSelection = false;

            do
            {
                //Limit the values the user can enter
                if (i <= stringArray.Length - 1)
                {
                    Console.WriteLine("You selected: " + stringArray[i] +
                    "\n Press [Enter] to continue.");
                    movieSelection = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("I'm sorry, you selected " + i + " please enter a value between 0-" + (stringArray.Length - 1));
                    i = Convert.ToInt32(Console.ReadLine());
                }
            } while (!movieSelection);


            /////
            ///Create an int array
            /////
            float[] numberArray = { 1.2F, 1.41F, 2.54F, 3.14F, 4.67F };

            Console.WriteLine("Here is a selection of numbers:");

            //Display an entire array
            numberArray.ToList().ForEach(Console.WriteLine);

            //User enters values
            Console.WriteLine("Please enter a single value between 0-" + (numberArray.Length - 1) + " to display one of those numbers.");
            //Read entered values and convert to "j"
            int j = Convert.ToInt32(Console.ReadLine());
            bool numberSelected = false;

            do
            {
                if (j <= numberArray.Length - 1)
                {
                    Console.WriteLine("You selected: " + numberArray[j] + "\nPress [Enter] to continue");
                    numberSelected = true;
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("I'm sorry, you selected " + j + " please enter a value between 0-" + (numberArray.Length - 1));
                    j = Convert.ToInt32(Console.ReadLine());
                }
            } while (!numberSelected);

            /////
            ///Create a list of strings
            /////
            List<string> aList = new List<string>();
            aList.Add("dogs");
            aList.Add("cats");
            aList.Add("birds");
            aList.Add("cows");
            aList.Add("meatballs");

            Console.WriteLine("It's raining out here and you get to select what exactly is coming down." + 
                "\nType in a number between 0-" + (aList.Count - 1) + " and press [Enter]");
            int k = Convert.ToInt32(Console.ReadLine());
            bool selection = false;

            do
            {
                if (k <= aList.Count - 1)
                {
                    bool finalChoice = false;
                    do
                    {
                        if (k <= aList.Count - 1)
                        {
                            //Display their selection, if they accept, tell them it is raining [k]
                            Console.WriteLine("You selected: " + aList[k] + ". Is that your final choice? Enter \"true\" or \"false\".");
                            
                            finalChoice = bool.Parse(Console.ReadLine());

                            if (!finalChoice)
                            {
                                Console.WriteLine("Okay then, what number would you like to choose instead?");
                                k = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry, please enter a number between 0-" + (aList.Count - 1));
                            k = Convert.ToInt32(Console.ReadLine());
                        }

                    } while (!finalChoice);
                    

                    Console.WriteLine("Okay then! It's raining " + aList[k] + ".");
                    selection = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("I'm sorry, please enter a number between 0-" + (aList.Count -1));
                    k = Convert.ToInt32(Console.ReadLine());
                }
            } while (!selection);

        }
    }
}
