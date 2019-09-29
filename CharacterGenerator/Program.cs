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
            string[] settingList = { "Prehistory", "Fantasy", "Wild West", "Present", "Post-Apocalypse", "Science Fiction" };
            string[] preHistoryName = { "Jhega", "Stego", "Mavlo", "Nozhe", "Izna", "Goc", "Ongic", "Khall", "Rovo" };
            string[] preHistoryTribe = { "Long Spear", "Big Rock", "Long Cave", "Half Moon", "Dark Forest" };
            string[] preHistoryJob = { "Club Swinger", "Gatherer", "Rock Thrower", "Herder", "Spearmaker", "Fire Maker", "Bone Carver" };
            string[] fantasyName = { "Reinwald", "Freman", "Tycho", "Hakon", "Darcy", "Clarinda", "Alia", "Mirth" };
            string[] fantasyJob = { "Mage", "Priest", "Beastmaster", "Archer", "Fighter" };
            string[] fantasyPlace = { "Kachon Province", "Osuan Harbor", "Faekrus Castle", "Ehan City", "Iowax Valley", "Isapish" };
            string[] wildWestFirstName = { "Elmer", "Marion", "Harrison", "Gordon", "Julius", "Florence", "Abbie", "Bertha" };
            string[] wildWestLastName = { "Lyons", "Brewer", "Hoffman", "Benson", "Franklin", "Sharp", "Lewis", "Skinner" };
            string[] wildWestJob = { "Sheriff", "Bandit", "Engineer", "Stagedriver", "Barkeep", "Shopkeepr" };
            string[] wildWestPlace = { "Redchapel", "Lonely Howl", "Freescar", "Rustler's Ridge", "Windy Trail", "Dry Spring" };
            string[] postApocName = { "Sulik", "Tandi", "Myron", "Cassidy", "Lenny", "Marcus", "Vic", "Dogmeat" };
            string[] postApocLocations = { "Arroyo", "Klamath", "Modoc", "New Reno", "Vault City", "Redding", "Broken Hills" };
            string[] postApocJob = { "Wanderer", "Gangster", "Trader", "Mercenary", "Mutant", "Caravaneer", "Raider" };
            string[] sciFiName = { "Riya", "Kaelyn", "Jexa", "Seliena", "Aydan", "Jaxtom", "Davon", "Brodrik" };
            string[] sciFiPlaceName = { "Dotroth Prime", "Neter II", "Strepatov Station", "Cion 1B", "Lebros 4", "Phiri 4482", "Proxima Centauri" };
            string[] sciFiJob = { "Robomancer", "Biolitech", "Quantum Statistician", "Mech Pilot", "Captain", "Bounty Hunter", "Pirate", "Asteroid Miner" };
            string[] firstName = { "Noah", "Emma", "Liam", "Olivia", "William", "Ava", "Mason", "Sophia" };
            string[] lastName = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" };
            string[] job = { "Plumber", "Miner", "Teacher", "Soldier", "Politician", "Programmer", "Firefighter", "Doctor" };
            string[] town = { "Westburg", "Southville", "East City", "Northton", "Seattle", "Carman", "Dallas", "Austin" };

            Random rand = new Random();

            int settingIndex = rand.Next(settingList.Length);
            string setting = settingList[settingIndex];
            Console.WriteLine(setting);

            if (setting == "Prehistory")
            {
                int nameIndex = rand.Next(preHistoryName.Length);
                int tribeIndex = rand.Next(preHistoryTribe.Length);
                int jobIndex = rand.Next(preHistoryJob.Length);
                
                Console.WriteLine("Welcome to pre-history, " + preHistoryName[nameIndex] + "!");
                Console.WriteLine(preHistoryName[nameIndex] + " is a " + preHistoryJob[jobIndex] + " from the " + preHistoryTribe[tribeIndex] + " tribe.");
            }
            else if (setting == "Fantasy")
            {
                int fantasyNameIndex = rand.Next(fantasyName.Length);
                int jobIndex = rand.Next(fantasyJob.Length);
                int placeIndex = rand.Next(fantasyPlace.Length);

                Console.WriteLine("Go slay some dragons, " + fantasyName[fantasyNameIndex] + "!");
                Console.WriteLine(fantasyName[fantasyNameIndex] + " is a " + fantasyJob[jobIndex] + " from " + fantasyPlace[placeIndex] + ".");
            }
            else if (setting == "Wild West")
            {
                int firstIndex = rand.Next(wildWestFirstName.Length);
                int lastIndex = rand.Next(wildWestLastName.Length);
                int jobIndex = rand.Next(wildWestJob.Length);
                int townIndex = rand.Next(wildWestPlace.Length);

                Console.WriteLine("Welcome to the Wild West, " + wildWestFirstName[firstIndex] + " " + wildWestLastName[lastIndex] + "!");
                Console.WriteLine(wildWestFirstName[firstIndex] + " is a " + wildWestJob[jobIndex] + " from " + wildWestPlace[townIndex] + ".");
            }
            else if (setting == "Present")
            {
                int firstIndex = rand.Next(firstName.Length);
                int lastIndex = rand.Next(lastName.Length);
                int jobIndex = rand.Next(job.Length);
                int townIndex = rand.Next(town.Length);

                Console.WriteLine("Welcome to the boring, normal world, " + firstName[firstIndex] + " " + lastName[lastIndex] + "!");
                Console.WriteLine(firstName[firstIndex] + " is a " + job[jobIndex] + " from " + town[townIndex] + ".");
            }
            else if (setting == "Post-Apocalypse")
            {
                int firstIndex = rand.Next(postApocName.Length);
                int jobIndex = rand.Next(postApocJob.Length);
                int townIndex = rand.Next(postApocLocations.Length);

                Console.WriteLine("Welcome to what's left of the world, " + postApocName[firstIndex] + "!");
                Console.WriteLine(postApocName[firstIndex] + " is a " + postApocJob[jobIndex] + " from " + postApocLocations[townIndex] + ".");
            }
            else if (setting == "Science Fiction")
            {
                int firstIndex = rand.Next(sciFiName.Length);
                int jobIndex = rand.Next(sciFiJob.Length);
                int townIndex = rand.Next(sciFiPlaceName.Length);

                Console.WriteLine("Welcome to the future, " + sciFiName[firstIndex] + "!");
                Console.WriteLine(sciFiName[firstIndex] + " is a " + sciFiJob[jobIndex] + " from " + sciFiPlaceName[townIndex] + ".");
            }
            else
            {
                Console.WriteLine("Failed to select a setting.");
            }

            //int firstIndex = rand.Next(firstName.Length);
            //int lastIndex = rand.Next(lastName.Length);
            //int jobIndex = rand.Next(job.Length);
            //int townIndex = rand.Next(town.Length);

            //Console.WriteLine("Welcome to the world, " + firstName[firstIndex] + " " + lastName[lastIndex] + "!");
            //Console.WriteLine(firstName[firstIndex] + " is a " + job[jobIndex] + " from " + town[townIndex] + ".");
        }
    }
}
