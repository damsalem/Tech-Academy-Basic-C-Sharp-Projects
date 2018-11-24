using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////
            /////(1) Create a list of integers.
            /////Ask the user for a number to divide each number in the list by.
            /////Write a loop that takes each integer in the list,
            /////divides it by the number the user entered, and displays the result to the screen.
            //List<float> divisbleNum = new List<float> { 12f, 24f, 32f, 48f };

            //Console.WriteLine("Please enter a number to divide each number in this list by.");
            //divisbleNum.ForEach(Console.WriteLine);
            //float divisor = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Thank you, here's what I've got:");

            //foreach (float number in divisbleNum)
            //{
            //    float quotient = number / divisor;
            //    Console.WriteLine(quotient);
            //}
            //Console.ReadLine();


            /////
            ///(2) Run that code, entering in non-zero numbers as the user. Look at the displayed results.
            /////

            // It runs well, changed the data type from INT to FLOAT to display decimals.


            /////
            ///(3) Run that code, entering in zero as the number to divide by. Note any error messages you get.
            /////

            // I got an infinity sign.


            /////
            ///(4) Run that code, entering in a string as the number to divide by. Note any error messages you get.
            /////

            // My error was: System.FormatException: 'Input string was not in a correct format.'


            /////
            ///(5) Now put the loop in a try/catch block.
            ///Below and outside of the try/catch block, make the program display a message to let you know
            ///the program has emerged from the try/catch block and continued on with program execution.
            ///In the catch block, display the error message to the screen.
            ///Then try various combinations of user input: valid numbers, zero and a string.
            ///Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
            /////

            List<decimal> divisbleNum1 = new List<decimal> { 12, 24, 32, 48 };

            try
            {
                Console.WriteLine("Please enter a number to divide each number in this list by.");
                divisbleNum1.ForEach(Console.WriteLine);
                decimal divisor1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Thank you, here's what I've got:");
                
                foreach (decimal number1 in divisbleNum1)
                {
                    decimal quotient1 = number1 / divisor1;
                    Console.WriteLine(quotient1);
                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please enter a number greater than 0");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only use numbers when performing the calculations");
            }
            finally
            {
                Console.WriteLine("Thank you for testing my simple math program. Press [Enter] to close.");
                Console.ReadLine();
            }
        }
    }
}
