using System.Threading.Tasks.Sources;
using System.Xml.Serialization;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Score Analyzer");
            Console.WriteLine("----------------------");

            List<double> scores = new List<double> { 9, 20, 24, 28, 30, 30, 37, 38, 43, 50};

            Console.WriteLine("1. Display Values \n2. Show Total \n3. Show Average \n4. Exit\n");
            char choice = '0';

            while (choice != '4')
            {
                Console.Write("Enter Choice: ");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        {
                            DisplayAll(scores);
                            break;
                        }

                    case '2':
                        {
                            DisplayTotal(scores);
                            break;
                        }

                    case '3':
                        {
                            DisplayAverage(scores);
                            break;
                        }

                    case '4':
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
    }
}
