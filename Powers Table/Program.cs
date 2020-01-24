using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Square, Cube;
            char userResponse = 'y';

            //while loop allows program to run again as long as the user inputs "y".
            while (userResponse == 'y')
            {
                Console.WriteLine("Please enter an integer.");
                int userNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Number\tSquare\tCube\n");
                
                //calculates squares and cubes from the integer 1 through whatever number the user chooses
                for (int Number = 1; Number <= userNumber;
               Number++)
                {
                    Square = Number * Number;
                    Cube = Square * Number;
                    Console.WriteLine("{0}\t{1}\t{2}", Number, Square, Cube);
                }

                Console.WriteLine("Would you like to continue? [y/n}");
                userResponse = char.Parse(Console.ReadLine());
            }
        }
    }
}
