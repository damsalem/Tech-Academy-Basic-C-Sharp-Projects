using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            /////
            ///Lists are more adaptable and powerful than arrays. 
            ///They can include any data type
            /////
            ////Create an integer list. 
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            /////
            ///Create a string list
            /////
            List<string> stringList = new List<string>();
            stringList.Add("Dani");
            stringList.Add("Amsalem");

            Console.WriteLine(stringList[0]);
            Console.ReadLine();


            /////
            ///Arrays are useful for fixed length sequences
            ///They are also useful when inserting images using the byte type
            /////
            ////Declare an array, create an object of it, and then define the length
            //int[] numArray = new int[5];

            ////Insert values into the array
            //numArray[0] = 2;
            //numArray[1] = 5;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //Console.WriteLine(numArray[3]);
            //Console.ReadLine();

            /////
            ///Create an array, instantiate it, and then insert values
            /////
            //int[] numArray1 = new int[] { 2, 5, 10, 200, 5000 };

            //Console.WriteLine(numArray1[3]);
            //Console.ReadLine();

            /////
            ///Instantiate an array (let C# instantiate it), and then insert values
            /////
            //int[] numArray2 = { 5, 2, 10, 200, 5000 };

            ////Update the values in position 4
            //numArray2[4] = 650;

            //Console.WriteLine(numArray2[4]);
            //Console.ReadLine();


        }
    }
}
