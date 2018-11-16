using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brodie_Character_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            int uinput;

            Console.WriteLine("Welcome to my character modifier program!");

            do
            {
                Console.WriteLine("Press a number based on the action that you want to perform:");
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Modify a character");
                Console.WriteLine("3. Delete a character");
                Console.WriteLine("4. Load all existing characters");
                Console.WriteLine("5. List all current characters");
                Console.WriteLine("6. Quit");
                Console.WriteLine();

                uinput = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (uinput == 1)
                {
                    characters.Add(CreateCharacter());
                }

                if (uinput == 2)
                {
                    //ModifyCharacter(created character from list);
                }

                if (uinput == 3)
                {

                }

                if (uinput == 4)
                {

                }

                if (uinput == 5)
                {

                }
            }
            while (uinput != 6);
        }

        static Character CreateCharacter()
        {
            Console.WriteLine("Enter a name for your character:");
            string charName = Console.ReadLine();
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
                sw.WriteLine(character.strength + " ");
                sw.Write(character.dexterity + " ");
                sw.Write(character.agility + " ");
                sw.Write(character.speed + " ");
                sw.Write(character.knowledge + " ");
            }
        }

        //static bool DeleteCharacter(List<Character> characters, string characterName)
        //{
        //    return
        //}

        //static Character LoadCharacter(string characterName)
        //{
        //    return
        //}

        //static List<Character> LoadCharacters()
        //{
        //    return
        //}

        //static void ListCharacters(List<Character> characters)
        //{

        //}
    }
}
