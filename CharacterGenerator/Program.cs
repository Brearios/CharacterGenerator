using System;

namespace CharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Character Generator! Press Y to generate a character, or Q to quit.");
            string letter = Console.ReadLine();
            do
            { 
                Generate();
                Console.WriteLine("Press Y to generate another character, or any other key to exit.");
                letter = Console.ReadLine();
            }
            while (letter == "Y");
            
        }
        static void Generate()
        {
            string[] firstName = { "Noah", "Emma", "Liam", "Olivia", "William", "Ava", "Mason", "Sophia" };

            string[] lastName = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };

            string[] job = { "Plumber", "Miner", "Teacher", "Soldier", "Politician", "Programmer", "Firefighter", "Doctor" };

            string[] town = { "Westburg", "Southville", "East City", "Northton", "Seattle", "Carman", "Dallas", "Austin" };

            Random rand = new Random();

            int firstIndex = rand.Next(firstName.Length);
            int lastIndex = rand.Next(lastName.Length);
            int jobIndex = rand.Next(job.Length);
            int townIndex = rand.Next(town.Length);

            Console.WriteLine("Welcome to the world, " + firstName[firstIndex] + " " + lastName[lastIndex] + "!");
            Console.WriteLine(firstName[firstIndex] + " is a " + job[jobIndex] + " from " + town[townIndex] + ".");
        }
    }
}
