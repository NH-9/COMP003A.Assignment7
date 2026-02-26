using System.Threading.Tasks.Sources;
using System.Xml.Serialization;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * The purpose of this program is to analyze a list of student scores. 
             * The program displays a menu and displays the data in various ways
             * depending on user input. User input is also used to exit the program.
             */

            Console.WriteLine("Student Score Analyzer");
            Console.WriteLine("----------------------");

            // scores are based on the actual stats shown on canvas for my precalc exam grading
            List<double> scores = new List<double> { 9, 20, 24, 28, 30, 30, 37, 38, 43, 50};

            Console.WriteLine("1. Display Values \n2. Show Total \n3. Show Average \n4. Exit\n");
            int choice = '0';

            // This loop prompts user for a choice and then displays the corresponding result,
            // repeating until the user chooses to exit or an error occurs.
            while (choice != 4)
            {
                Console.Write("Enter Choice: ");

                /* 
                 * I would have used 'continue' instead of 'break' here but the assignment
                 * constraints say not to use re-prompting loops for invalid input and I'm
                 * not sure if continuing the loop here would count for that. 
                 * 
                 * This aside, the purpose is to simply recognize an incompatible input type
                 * and fail gracfully rather than crash abruptly.
                 */
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number Input\n");
                    break;
                }

                if (choice >= 1 && choice <= 4)
                {
                    // Input Valid
                }
                else
                {
                    Console.WriteLine("Number Input Out of Range\n");
                    break;
                }

                switch (choice)
                {
                    case 1:
                        {
                            DisplayAll(scores);
                            break;
                        }

                    case 2:
                        {
                            DisplayTotal(scores);
                            break;
                        }

                    case 3:
                        {
                            DisplayAverage(scores);
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Program Ended.");
                            break;
                        }
                }
            }   
        }

        static void DisplayAll(List<double> scores)
        {
            Console.Write("Scores: ");
            foreach (double score in scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine("\n");
        }

        static void DisplayTotal(List<double> scores)
        {
            double total = 0;
            foreach (double score in scores)
            {
                total += score;
            }
            Console.WriteLine($"Total: {total}\n");
        }

        static void DisplayAverage(List<double> scores)
        {
            double average = 0;
            foreach (double score in scores)
            {
                average += score;
            }
            average /= scores.Count;
            Console.WriteLine($"Average: {average}\n");
        }

        // Debugging Example
        /*
         * While implementing input validation, I noticed that inputing 4 into the console would not actually end the program.
         * This turned out to be because the condition for the loop had single quotes around the 4. This is because I initially
         * converted the input value to 'char', before realizing I would need an 'int' value to validate inputs within a
         * numeric range. While changing the value type I forgot to make this adjustment to the loop condition. After encountering
         * the error, I carefully read through the code and quickly realized my mistake. No other major issues were encountered
         * during the coding process.
         */
    }
}
