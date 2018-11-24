using System;

namespace ExceptionHandlingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Now we'll be dividing the two.");

                int numberThree = numberOne / numberTwo;

                Console.WriteLine(numberOne + " divided by " + numberTwo + " = " + numberThree);
                Console.ReadLine();
            }
            /////This catch will get all errors.
            //catch (SystemException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            catch (FormatException)
            {
                Console.WriteLine("Oops. Please enter a valid number next time.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Hmmm. That didn't quite work. Please don't divide by 0.");
            }
            //This is a general catch
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //The FINALLY is always run, whether the try or catch is done
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
