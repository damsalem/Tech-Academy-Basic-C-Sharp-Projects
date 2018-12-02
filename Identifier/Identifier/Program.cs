using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//"namespace" a way to organize and separate code
namespace Identifier
{
    //"public" = access modifier
    //"class" = showing that this is a class
    //"program" = name of the class
    public class Program
    {
        //"static" = a modifier that belongs to the type itself rather than to a specific object.
        //"void" = a return type specifying that the method doesn't return a value.
        //"main" = the entry point of a C# application, there can only be one
        //"string" = data type
        //"args" = string array making configuring programs simpler
        static void Main(string[] args)
        {
            //"SampleClass" = defines a class
            //"anyName" = declaring a name for the variable/method
            //"new" = operator used to instantiate objects
            SampleClass anyName = new SampleClass();

            //"Console.WriteLine" = writes something to the screen
            Console.WriteLine("Enter any number to add 5 to it.");

            //"int" = integer data type
            //"userNum" = naming the integer
            //"int32" = 32 bit integer
            //"parse" = converts the string to an integer
            //"console.readline" = takes the data from user input
            int userNum = Int32.Parse(Console.ReadLine());

            //"anyName" = the name of the method declared above
            //"testClass" = the name of the method within the class
            int result = anyName.testClass(userNum);

            Console.WriteLine("Your number is: " + result);
            Console.ReadLine();
        }
    }
}
