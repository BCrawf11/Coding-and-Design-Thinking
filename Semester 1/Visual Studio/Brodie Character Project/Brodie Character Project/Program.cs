using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brodie_Character_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int uinput;
            List<Character> characters = new List<Character>();

            Console.WriteLine("Welcome to my character modifier program!");
            Console.WriteLine();

            do
            {
                Console.WriteLine("***************************************************************************************************************");
                Console.WriteLine("Press a number based on the action that you want to perform: (You should load everything beforehand. Hint hint)");
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Modify a character");
                Console.WriteLine("3. Delete a character");
                Console.WriteLine("4. Load all existing characters");
                Console.WriteLine("5. List all current characters");
                Console.WriteLine("6. Quit");
                Console.WriteLine("Remember to spell the name of your character CASE SENSITIVE in all prompts.");
                Console.WriteLine("***************************************************************************************************************");
                Console.WriteLine();

                uinput = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (uinput == 1)
                {
                    characters.Add(CreateCharacter());
                }

                if (uinput == 2)
                {
                    bool modified = false;
                    characters = LoadCharacters();

                    Console.WriteLine("Which character would you like to modify?");
                    string input = Console.ReadLine();

                    for (int i = 0; i < characters.Count; i++)
                    {
                        if (characters[i].name == input)
                        {
                            ModifyCharacter(characters[i]);
                            modified = true;
                            break;
                        }
                    }

                    if (modified == false)
                    {
                        Console.WriteLine("This character was not found.");
                    }
                    Console.WriteLine();
                }

                if (uinput == 3)
                {
                    Console.WriteLine("Which character would you like to delete?");
                    string input = Console.ReadLine();

                    if (DeleteCharacter(characters, input) == true)
                    {
                        Console.WriteLine("This character was deleted! Load again to update.");
                    }
                    if (DeleteCharacter(characters, input) == false)
                    {
                        Console.WriteLine("This character was not deleted, because it couldn't be found.");
                    }
                }

                if (uinput == 4)
                {
                    characters = LoadCharacters();
                    Console.WriteLine("Characters loaded!");
                    Console.WriteLine();
                }

                if (uinput == 5)
                {
                    PrintAllCharacters(characters);
                }
            }
            while (uinput != 6);
        }

        static Character CreateCharacter()
        {
            string charName = "";
            bool correct = true;

            do
            {
                List<Character> characters = new List<Character>();
                characters = LoadCharacters();

                Console.WriteLine("Enter a name for your character:");
                charName = Console.ReadLine();
                correct = true;

                for (int i = 0; i < characters.Count; i++)
                {
                    if (charName == characters[i].name)
                    {
                        Console.WriteLine("This name has already been chosen. Please enter a new name.");
                        Console.WriteLine();
                        correct = false;
                    }
                }

                if (correct == true)
                {
                    break;
                }
            }
            while (true);


            Console.WriteLine("Enter a strength for your character:");
            int strength = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a dexterity for your character:");
            int dexterity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an agility for your character:");
            int agility = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a speed for your character:");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a knowledge level for your character:");
            int knowledge = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Character character = new Character(charName, strength, dexterity, agility, speed, knowledge);
            SaveCharacter(character);

            return character;
        }

        static void ModifyCharacter(Character character)
        {
            string uinput = "";
            string uinput2 = "";
            int uinput3 = 0;
            string uinput4 = "";

            do
            {
                Console.WriteLine("Please enter an attribute you would like to modify:");
                uinput = Console.ReadLine();

                if (uinput == "name")
                {
                    Console.WriteLine("Choose a new name for this character.");
                    uinput2 = Console.ReadLine();
                    character.name = uinput2;
                    SaveCharacter(character);

                    Console.WriteLine("Are there any other attributes that you would like to modify?");
                    uinput4 = Console.ReadLine();
                }
                else if (uinput == "strength")
                {
                    Console.WriteLine("Choose a new strength.");
                    uinput3 = int.Parse(Console.ReadLine());
                    character.strength = uinput3;
                    SaveCharacter(character);

                    Console.WriteLine("Are there any other attributes that you would like to modify?");
                    uinput4 = Console.ReadLine();
                }
                else if (uinput == "dexterity")
                {
                    Console.WriteLine("Choose a new dexterity.");
                    uinput3 = int.Parse(Console.ReadLine());
                    character.dexterity = uinput3;
                    SaveCharacter(character);

                    Console.WriteLine("Are there any other attributes that you would like to modify?");
                    uinput4 = Console.ReadLine();
                }
                else if (uinput == "agility")
                {
                    Console.WriteLine("Choose a new agility.");
                    uinput3 = int.Parse(Console.ReadLine());
                    character.agility = uinput3;
                    SaveCharacter(character);

                    Console.WriteLine("Are there any other attributes that you would like to modify?");
                    uinput4 = Console.ReadLine();
                }
                else if (uinput == "speed")
                {
                    Console.WriteLine("Choose a new speed.");
                    uinput3 = int.Parse(Console.ReadLine());
                    character.speed = uinput3;
                    SaveCharacter(character);

                    Console.WriteLine("Are there any other attributes that you would like to modify?");
                    uinput4 = Console.ReadLine();
                }
                else if (uinput == "knowledge")
                {
                    Console.WriteLine("Choose a new knowledge level.");
                    uinput3 = int.Parse(Console.ReadLine());
                    character.knowledge = uinput3;
                    SaveCharacter(character);

                    Console.WriteLine("Are there any other attributes that you would like to modify?");
                    uinput4 = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("This is an invalid attribute. Please try again.");
                }
            }
            while (uinput4 != "no");
        }

        static void SaveCharacter(Character character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.name + ".txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(character.name);
                sw.WriteLine(character.strength);
                sw.WriteLine(character.dexterity);
                sw.WriteLine(character.agility);
                sw.WriteLine(character.speed);
                sw.WriteLine(character.knowledge);
            }
        }

        static bool DeleteCharacter(List<Character> characters, string characterName)
        {
            bool deleted = false;

            for (int i = 0; i < characters.Count; i++)
            {
                if (characterName == characters[i].name)
                {
                    if (File.Exists(@"" + characterName + ".txt"))
                    {
                        File.Delete(@"" + characterName + ".txt");
                    }
                    deleted = true;
                    break;
                }
            }

            return deleted;
        }

        static Character LoadCharacter(string path)
        {
            List<string> file = new List<string>();

            file.Clear();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }

            Character character = new Character(file[0], int.Parse(file[1]), int.Parse(file[2]), int.Parse(file[3]), int.Parse(file[4]), int.Parse(file[5]));

            return character;
        }

        static List<Character> LoadCharacters()
        {

            List<Character> characters = new List<Character>();
            string path = AppDomain.CurrentDomain.BaseDirectory;

            foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
            {
                characters.Add(LoadCharacter(file));
            }

            return characters;
        }

        static void PrintAllCharacters(List<Character> characters)
        {
            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine(characters[i].name);
                Console.WriteLine("strength: " + characters[i].strength);
                Console.WriteLine("dexterity: " + characters[i].dexterity);
                Console.WriteLine("agility: " + characters[i].agility);
                Console.WriteLine("speed: " + characters[i].speed);
                Console.WriteLine("knowledge: " + characters[i].knowledge);
                Console.WriteLine();
            }
        }
    }
}
