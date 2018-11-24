using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////
            /////(1) Create an array of strings
            ///////
            //string[] stringNames = { "David", "Teri", "Juliet", "Megan", "Dani", };

            ////Display all strings in the array
            //Console.WriteLine("This is the 1st step, creating an array of names, written as strings.");
            //stringNames.ToList().ForEach(Console.WriteLine);

            ////Create a new variable from user input
            //Console.WriteLine("Now, please write your own name and hit [Enter] to replace all of the items on the list.");
            //string userNames = Console.ReadLine();

            ////Update all strings in the array with the user input
            //for (int i = 0; i < stringNames.Length; i++)
            //{
            //    stringNames[i] = userNames;
            //}

            //Console.WriteLine("Now hit [Enter] to display the updated array");
            //Console.ReadLine();

            ////Display the new strings in the array
            //for (int j = 0; j < stringNames.Length; j++)
            //{
            //    Console.WriteLine(stringNames[j]);
            //}

            //Console.ReadLine();


            ///////
            /////(2) Create an infinite loop
            ///////
            ////Console.WriteLine("This isthe 2nd step, an infinite loop");
            ////int k = 0;

            ////while (k == 0)
            ////{
            ////    Console.WriteLine(userNames[0]);
            ////}


            ///////
            /////(3) Fix the infinite loop so it will execute
            ///////
            //Console.WriteLine("This is the 3rd step, an ending loop that writes a string 7 times." +
            //    "\nPress [Enter] to start");
            //Console.ReadLine();

            //for (int l = 0; l < 7; l++)
            //{
            //    Console.WriteLine("Fee, Fi, Fo, Fum");
            //}
            //Console.ReadLine();


            ////////
            /////(4) Create a loop where the comparison used to determine whether to continue iterating the loop is a /</ operator.
            ///////
            //Console.WriteLine("This is the 4th step, a loop using a < operator." +
            //    "\nPress [Enter] to start.");
            //Console.ReadLine();

            //for (int m = 0; m < 3; m++)
            //{
            //    Console.WriteLine("Eenie, Meenie, Miney, Mo");
            //}
            //Console.ReadLine();


            ///////
            /////(5) Create a loop where the comparison used to determine whether to continue iterating the loop is a /</= operator.
            ///////
            //Console.WriteLine("This is the 5th step, a loop using a <= operator" +
            //    "\nPress [Enter] to start.");
            //Console.ReadLine();

            //for (int n = 0; n <= 5; n++)
            //{
            //    Console.WriteLine("Rumplestiltskin");
            //}
            //Console.ReadLine();


            ///////
            /////(6) Create a list of strings where each item is unique. 
            /////Display the list of strings.
            /////Ask the user to select text to search within the list.
            /////Create a loop that iterates through the list and displays the index containing the matching text.
            ///////
            //List<String> familyNames = new List<string>();
            //familyNames.Add("david");
            //familyNames.Add("teri");
            //familyNames.Add("juliet");
            //familyNames.Add("megan");
            //familyNames.Add("kelli");
            //familyNames.Add("frankie");


            ////Display the list of strings
            //Console.WriteLine("This is the 6th step, a list of names in my family.");
            //familyNames.ForEach(Console.WriteLine);

            ////Ask the user to enter text to search within the list
            //Console.WriteLine("Please enter a couple of letters of text and hit [Enter] to see if there are any matches.");
            //string searchText = Console.ReadLine();

            //Console.WriteLine("You entered \"" + searchText + "\" and this came up with:");

            ////Create a loop that iterates through the list and displays the index containing the matching text.
            //foreach (string name in familyNames)
            //{
            //    if (name.Contains(searchText))
            //    {
            //        Console.WriteLine(name);
            //        int indexOfValue = familyNames.IndexOf(name);
            //        Console.WriteLine(indexOfValue);
            //    }
            //}
            //Console.ReadLine();


            ///////
            /////(7) Add code to that above loop that tells a user if they put in text that isn’t in the List.
            ///////
            //List<String> familyNames = new List<string>();
            //familyNames.Add("david");
            //familyNames.Add("teri");
            //familyNames.Add("juliet");
            //familyNames.Add("megan");
            //familyNames.Add("kelli");
            //familyNames.Add("frankie");


            ////Display the list of strings
            //Console.WriteLine("This is the 7th step, a list of names in my family.");
            //familyNames.ForEach(Console.WriteLine);

            ////Ask the user to enter text to search within the list
            //Console.WriteLine("Please enter a couple of letters of text and hit [Enter] to see if there are any matches.");
            //string searchText = Console.ReadLine();

            //Console.WriteLine("You entered \"" + searchText + "\" and this came up with:");
            //bool foundMatch = false;

            ////Create a loop that iterates through the list and displays the index containing the matching text.
            //do
            //{
            //    foreach (string name in familyNames)
            //    {

            //        if (name.Contains(searchText))
            //        {
            //            int indexOfValue = familyNames.IndexOf(name);
            //            foundMatch = true;
            //            Console.WriteLine(name + " " + indexOfValue);
            //        }
            //    }
            //    if (!foundMatch)
            //    {
            //        Console.WriteLine("Sorry, please enter letters that match the list items.");
            //        searchText = Console.ReadLine();
            //    }
            //} while (!foundMatch);

            //Console.ReadLine();


            ///////
            /////(8) Add code to that above loop that stops it from executing once a match has been found.
            ///////
            //List<String> familyNames = new List<string>();
            //familyNames.Add("david");
            //familyNames.Add("teri");
            //familyNames.Add("juliet");
            //familyNames.Add("megan");
            //familyNames.Add("kelli");
            //familyNames.Add("frankie");


            ////Display the list of strings
            //Console.WriteLine("This is the 7th step, a list of names in my family.");
            //familyNames.ForEach(Console.WriteLine);

            ////Ask the user to enter text to search within the list
            //Console.WriteLine("Please enter a couple of letters of text and hit [Enter] to see if there are any matches.");
            //string searchText = Console.ReadLine();

            //Console.WriteLine("You entered \"" + searchText + "\" and this came up with:");
            //bool foundMatch = false;

            ////Create a loop that iterates through the list and displays the index containing the matching text but stops on the first match
            //do
            //{
            //    foreach (string name in familyNames)
            //    {

            //        if (name.Contains(searchText))
            //        {
            //            int indexOfValue = familyNames.IndexOf(name);
            //            foundMatch = true;
            //            Console.WriteLine(name + " " + indexOfValue);
            //            break;
            //        }
            //    }
            //    if (!foundMatch)
            //    {
            //        Console.WriteLine("Sorry, please enter letters that match the list items.");
            //        searchText = Console.ReadLine();
            //    }
            //} while (!foundMatch);

            //Console.ReadLine();


            ///////
            /////(9) Create a List of strings that has at least two identical strings in the List. 
            /////Ask the user to select text to search for in the List. 
            /////Create a loop that iterates through the list and then
            /////displays the indices of the array that contain matching text on the screen.
            ///////
            //List<string> cities = new List<string>();
            //cities.Add("san jose");
            //cities.Add("san jose");
            //cities.Add("portland");
            //cities.Add("los angeles");
            //cities.Add("new york");
            //cities.Add("clearwater");

            //Console.WriteLine("The following is a list of cities:");
            //cities.ForEach(Console.WriteLine);
            //Console.WriteLine("Please enter text to search for in the list");

            //string cityLetters = Console.ReadLine();
            //bool searchMatch = false;

            //do
            //{
            //    for (int i = 0; i < cities.Count; i++)
            //    {
            //        if (cities[i].Contains(cityLetters))
            //        {
            //            Console.WriteLine(i);
            //            searchMatch = true;
            //        }
            //    }
            //} while (!searchMatch);
            //Console.ReadLine();


            ///////
            /////(10) Add code to that above loop that tells a user if they put in text that isn’t in the List.
            ///////
            //List<string> cities = new List<string>();
            //cities.Add("san jose");
            //cities.Add("san jose");
            //cities.Add("portland");
            //cities.Add("los angeles");
            //cities.Add("new york");
            //cities.Add("clearwater");

            //Console.WriteLine("The following is a list of cities:");
            //cities.ForEach(Console.WriteLine);
            //Console.WriteLine("Please enter text to search for in the list");

            //string cityLetters = Console.ReadLine();
            //bool searchMatch = false;

            //do
            //{
            //    for (int i = 0; i < cities.Count; i++)
            //    {
            //        if (cities[i].Contains(cityLetters))
            //        {
            //            Console.WriteLine(i);
            //            searchMatch = true;
            //        }
            //    }
            //    if (!searchMatch)
            //    {
            //        Console.WriteLine("I'm sorry, please enter text that matches something in the list");
            //        cityLetters = Console.ReadLine();
            //    }
            //} while (!searchMatch);
            //Console.ReadLine();


            /////
            ///(11) Create a List of strings that has at least two identical strings in the List.
            ///Create a foreach loop that evaluates each item in the list,
            ///and displays a message showing the string and whether or not it has already appeared in the list.
            /////
            List<string> phones = new List<string>() { "iPhone 8", "iPhone X", "iPhone X", "Galaxy S9", "Galaxy Note9", "Google Pixel 3",};
            Console.WriteLine("The following is a list of phones. One in the list is a duplicate.");
            phones.ForEach(Console.WriteLine);
            Console.ReadLine();

            List<string> myList = new List<string>();
            List<string> duplicates = new List<string>();

            foreach (string phone in phones)
            {
                if (!myList.Contains(phone))
                {
                    myList.Add(phone);
                }
                else
                {
                    duplicates.Add(phone);
                }
            }
            duplicates.ForEach(Console.WriteLine);
            Console.ReadLine();
            
        }
    }
}
