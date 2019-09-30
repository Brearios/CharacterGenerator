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
                Stats();
                //GenerateStat(); Need to refactor stats to a method
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
            //Console.WriteLine("This character is from " + setting);

            if (setting == "Prehistory")
            {
                int nameIndex = rand.Next(preHistoryName.Length);
                int tribeIndex = rand.Next(preHistoryTribe.Length);
                int jobIndex = rand.Next(preHistoryJob.Length);

                Console.WriteLine("Welcome to pre-historic tribalism, " + preHistoryName[nameIndex] + "!");
                Console.WriteLine(preHistoryName[nameIndex] + " is a " + preHistoryJob[jobIndex] + " from the " + preHistoryTribe[tribeIndex] + " tribe.");               
            }
            else if (setting == "Fantasy")
            {
                int fantasyNameIndex = rand.Next(fantasyName.Length);
                int jobIndex = rand.Next(fantasyJob.Length);
                int placeIndex = rand.Next(fantasyPlace.Length);

                Console.WriteLine("Welcome to a world of fantasy " + fantasyName[fantasyNameIndex] + "! Now go slay some dragons!");
                Console.WriteLine(fantasyName[fantasyNameIndex] + " is a " + fantasyJob[jobIndex] + " from " + fantasyPlace[placeIndex] + ".");
            }
            else if (setting == "Wild West")
            {
                int firstIndex = rand.Next(wildWestFirstName.Length);
                int lastIndex = rand.Next(wildWestLastName.Length);
                int jobIndex = rand.Next(wildWestJob.Length);
                int townIndex = rand.Next(wildWestPlace.Length);

                Console.WriteLine("Welcome to the Wild West, " + wildWestFirstName[firstIndex] + " " + wildWestLastName[lastIndex] + " - watch out for rattlesnakes!");
                Console.WriteLine(wildWestFirstName[firstIndex] + " is a " + wildWestJob[jobIndex] + " from " + wildWestPlace[townIndex] + ".");
            }
            else if (setting == "Present")
            {
                int firstIndex = rand.Next(firstName.Length);
                int lastIndex = rand.Next(lastName.Length);
                int jobIndex = rand.Next(job.Length);
                int townIndex = rand.Next(town.Length);

                Console.WriteLine("Welcome to the ordinary, boring world, " + firstName[firstIndex] + " " + lastName[lastIndex] + "!");
                Console.WriteLine(firstName[firstIndex] + " is a " + job[jobIndex] + " from " + town[townIndex] + ".");
            }
            else if (setting == "Post-Apocalypse")
            {
                int firstIndex = rand.Next(postApocName.Length);
                int jobIndex = rand.Next(postApocJob.Length);
                int townIndex = rand.Next(postApocLocations.Length);

                Console.WriteLine("Welcome," + postApocName[firstIndex] + " to what's left - the post-apocalypse!");
                Console.WriteLine(postApocName[firstIndex] + " is a " + postApocJob[jobIndex] + " from " + postApocLocations[townIndex] + ".");
            }
            else if (setting == "Science Fiction")
            {
                int firstIndex = rand.Next(sciFiName.Length);
                int jobIndex = rand.Next(sciFiJob.Length);
                int townIndex = rand.Next(sciFiPlaceName.Length);

                Console.WriteLine("Welcome to the future, " + sciFiName[firstIndex] + "! Maybe *you'll* have a flying car.");
                Console.WriteLine(sciFiName[firstIndex] + " is a " + sciFiJob[jobIndex] + " from " + sciFiPlaceName[townIndex] + ".");
            }
            else
            {
                Console.WriteLine("Failed to select a setting.");
            }

        }
        static void Stats()
        {
            Random rand = new Random();

            int intellectRoll = rand.Next(0, 100);
            int strengthRoll = rand.Next(0, 100);
            int agilityRoll = rand.Next(0, 100);
            int staminaRoll = rand.Next(0, 100);
            int energyRoll = rand.Next(0, 100);
            int perceptionRoll = rand.Next(0, 100);
            int luckRoll = rand.Next(0, 100);
            int charismaRoll = rand.Next(0, 100);
            int intellect;
            int strength;
            int agility;
            int stamina;
            int energy;
            int perception;
            int luck;
            int charisma;

            if (intellectRoll < 4)
            {
                intellect = 1;
            }
            else if (intellectRoll < 11)
            {
                intellect = 2;
            }
            else if (intellectRoll < 21)
            {
                intellect = 3;
            }
            else if (intellectRoll < 34)
            {
                intellect = 4;
            }
            else if (intellectRoll < 50)
            {
                intellect = 5;
            }
            else if (intellectRoll < 66)
            {
                intellect = 6;
            }
            else if (intellectRoll < 79)
            {
                intellect = 7;
            }
            else if (intellectRoll < 89)
            {
                intellect = 8;
            }
            else if (intellectRoll < 96)
            {
                intellect = 9;
            }
            else // > 96
            {
                intellect = 10;
            }

            if (strengthRoll < 4)
            {
                strength = 1;
            }
            else if (strengthRoll < 11)
            {
                strength = 2;
            }
            else if (strengthRoll < 21)
            {
                strength = 3;
            }
            else if (strengthRoll < 34)
            {
                strength = 4;
            }
            else if (strengthRoll < 50)
            {
                strength = 5;
            }
            else if (strengthRoll < 66)
            {
                strength = 6;
            }
            else if (strengthRoll < 79)
            {
                strength = 7;
            }
            else if (strengthRoll < 89)
            {
                strength = 8;
            }
            else if (strengthRoll < 96)
            {
                strength = 9;
            }
            else // > 96
            {
                strength = 10;
            }

            if (agilityRoll < 4)
            {
                agility = 1;
            }
            else if (agilityRoll < 11)
            {
                agility = 2;
            }
            else if (agilityRoll < 21)
            {
                agility = 3;
            }
            else if (agilityRoll < 34)
            {
                agility = 4;
            }
            else if (agilityRoll < 50)
            {
                agility = 5;
            }
            else if (agilityRoll < 66)
            {
                agility = 6;
            }
            else if (agilityRoll < 79)
            {
                agility = 7;
            }
            else if (agilityRoll < 89)
            {
                agility = 8;
            }
            else if (agilityRoll < 96)
            {
                agility = 9;
            }
            else // > 96
            {
                agility = 10;
            }

            if (staminaRoll < 4)
            {
                stamina = 60;
            }
            else if (staminaRoll < 11)
            {
                stamina = 70;
            }
            else if (staminaRoll < 21)
            {
                stamina = 80;
            }
            else if (staminaRoll < 34)
            {
                stamina = 90;
            }
            else if (staminaRoll < 50)
            {
                stamina = 100;
            }
            else if (staminaRoll < 66)
            {
                stamina = 110;
            }
            else if (staminaRoll < 79)
            {
                stamina = 120;
            }
            else if (staminaRoll < 89)
            {
                stamina = 130;
            }
            else if (staminaRoll < 96)
            {
                stamina = 140;
            }
            else // > 96
            {
                stamina = 150;
            }

            if (energyRoll < 4)
            {
                energy = 80;
            }
            else if (energyRoll < 11)
            {
                energy = 85;
            }
            else if (energyRoll < 21)
            {
                energy = 90;
            }
            else if (energyRoll < 34)
            {
                energy = 95;
            }
            else if (energyRoll < 50)
            {
                energy = 100;
            }
            else if (energyRoll < 66)
            {
                energy = 105;
            }
            else if (energyRoll < 79)
            {
                energy = 110;
            }
            else if (energyRoll < 89)
            {
                energy = 115;
            }
            else if (energyRoll < 96)
            {
                energy = 120;
            }
            else // > 96
            {
                energy = 125;
            }

            if (perceptionRoll < 4)
            {
                perception = 1;
            }
            else if (perceptionRoll < 11)
            {
                perception = 2;
            }
            else if (perceptionRoll < 21)
            {
                perception = 3;
            }
            else if (perceptionRoll < 34)
            {
                perception = 4;
            }
            else if (perceptionRoll < 50)
            {
                perception = 5;
            }
            else if (perceptionRoll < 66)
            {
                perception = 6;
            }
            else if (perceptionRoll < 79)
            {
                perception = 7;
            }
            else if (perceptionRoll < 89)
            {
                perception = 8;
            }
            else if (perceptionRoll < 96)
            {
                perception = 9;
            }
            else // > 96
            {
                perception = 10;
            }

            if (luckRoll < 4)
            {
                luck = 1;
            }
            else if (luckRoll < 11)
            {
                luck = 2;
            }
            else if (luckRoll < 21)
            {
                luck = 3;
            }
            else if (luckRoll < 34)
            {
                luck = 4;
            }
            else if (luckRoll < 50)
            {
                luck = 5;
            }
            else if (luckRoll < 66)
            {
                luck = 6;
            }
            else if (luckRoll < 79)
            {
                luck = 7;
            }
            else if (luckRoll < 89)
            {
                luck = 8;
            }
            else if (luckRoll < 96)
            {
                luck = 9;
            }
            else // > 96
            {
                luck = 10;
            }

            if (charismaRoll < 4)
            {
                charisma = 1;
            }
            else if (charismaRoll < 11)
            {
                charisma = 2;
            }
            else if (charismaRoll < 21)
            {
                charisma = 3;
            }
            else if (charismaRoll < 34)
            {
                charisma = 4;
            }
            else if (charismaRoll < 50)
            {
                charisma = 5;
            }
            else if (charismaRoll < 66)
            {
                charisma = 6;
            }
            else if (charismaRoll < 79)
            {
                charisma = 7;
            }
            else if (charismaRoll < 89)
            {
                charisma = 8;
            }
            else if (charismaRoll < 96)
            {
                charisma = 9;
            }
            else // > 96
            {
                charisma = 10;
            }
            Console.WriteLine("with the following attributes:");
            Console.WriteLine("Intellect: " + intellect);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Agility: " + agility);
            Console.WriteLine("Stamina: " + stamina);
            Console.WriteLine("Energy: " + energy);
            Console.WriteLine("Perception: " + perception);
            Console.WriteLine("Luck: " + luck);
            Console.WriteLine("Charisma: " + charisma);
        }
    }
}
