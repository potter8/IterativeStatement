/*Creater: Matthew Potter
 * 01/29/2021
 * IterativeStatement
 */
using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger value between 1 and 100");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    for (int i = 1; i <= value_of_input; i++)
                    {
                        Console.WriteLine("You have entered" + " " + value_of_input.ToString() + "." + " " +
                          "This is the current integer value in the loop :" + i.ToString());
                    }
                }

            }
            catch 
            {
                Console.WriteLine("Please enter an interger between 1 and 100");
                Console.WriteLine("Please press any key to exit and try again");
            }
        }
    }
}
