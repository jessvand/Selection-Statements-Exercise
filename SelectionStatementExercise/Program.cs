using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNum = r.Next(2, 12);
            int userInput = 0;

            while (userInput != favNum)
            {

                Console.WriteLine("Guess my favorite number (2-12):");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNum)
                {
                    Console.WriteLine($"Too low!\nYour guess: {userInput}");
                }

                else if (userInput > favNum)
                {
                    Console.WriteLine($"Too high!\nYour guess: {userInput}");
                }

                else
                {
                    Console.WriteLine($"YEEAAHHH! You got it!\nYour guess: {userInput}");
                }
            }

        }
    }



    
}
