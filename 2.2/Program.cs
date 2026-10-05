using System;

namespace WorkplaceApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter team name: ");
            string teamName = Console.ReadLine() ?? string.Empty;
            Team team = new Team(teamName);

            bool isAddingWorkers = true;

            while (isAddingWorkers)
            {
                Console.WriteLine("\nSelect worker role:");
                Console.WriteLine("1 - Developer");
                Console.WriteLine("2 - Manager");
                Console.WriteLine("0 - Finish adding workers");
                Console.Write("Your choice: ");

                string choice = Console.ReadLine() ?? string.Empty;

                if (choice == "0")
                {
                    isAddingWorkers = false;
                }
                else if (choice == "1")
                {
                    Console.Write("Enter developer's full name: ");
                    string name = Console.ReadLine() ?? string.Empty;

                    Developer developer = new Developer(name);
                    developer.FillWorkDay();
                    team.AddWorker(developer);
                }
                else if (choice == "2")
                {
                    Console.Write("Enter manager's full name: ");
                    string name = Console.ReadLine() ?? string.Empty;

                    Manager manager = new Manager(name);
                    manager.FillWorkDay();
                    team.AddWorker(manager);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            Console.WriteLine("\n--- General Team Information ---");
            team.ShowTeamInfo();

            Console.WriteLine("\n--- Detailed Team Information ---");
            team.ShowDetailedInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}