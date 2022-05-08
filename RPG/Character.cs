using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public enum CharacterType
    {
        //An enum containing 9 different Classes to play
        Fighter, Mage, Cleric, Bard, Rouge, Paladin, Barbarian, Archer, Druid
    }
    //Property's to insert information into.
    //It inheritage from EntityBasicStats
    public class CharacterCreator : EntityBasicStats
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }

        //Type/Class
        public CharacterType Type { get; set; }
    }
    public class CharacterCreatorGraphics
    {
        static internal List<CharacterCreator> Player(List<CharacterCreator> Party)
        {
            //sets level to 1 and xp to 0. It's a new Character
            int level = 1, xp = 0;
            string name;
            bool exit = false;
            ConsoleKeyInfo cho;

            //instaniets a new Object of CharacterCreator
            CharacterCreator CharacterObj = new();

            //entering a Loop where you can rerole your stats until you like-em.
            do
            {
                Console.Clear();
                Console.WriteLine("*** Charactor Creator ***\n");
                Console.WriteLine("Role Dice for your Skills!");
                Console.ReadKey(true);

                //roles 3XD6 & stores the info in the attributes 
                CharacterObj.Strength = Tools.RoleD6(3);
                CharacterObj.Agility = Tools.RoleD6(3);
                CharacterObj.Smarts = Tools.RoleD6(3);
                CharacterObj.Magic = Tools.RoleD6(3);

                //Shows the results
                Console.WriteLine("*** Your Skills ***");
                Console.WriteLine($"Strength: {CharacterObj.Strength}");
                Console.WriteLine($"Agility: {CharacterObj.Agility}");
                Console.WriteLine($"Smarts: {CharacterObj.Smarts}");
                Console.WriteLine($"Magic: {CharacterObj.Magic}");
                Console.WriteLine("");

                //If you like-em press 1 to continue
                Console.WriteLine("When you like your stats press 1");
                cho = Console.ReadKey(true);
                if(cho.Key == ConsoleKey.D1)
                    exit = true;

            } while (exit == false);

            //Choose your Character.
            do {
                Console.Clear();
                Console.WriteLine("Choose your Type:");
                int i = 0;
                //Print's out the available Characters
                foreach (var item in Enum.GetValues(typeof(CharacterType)))
                {
                    ++i;
                    Console.WriteLine($"{i}. {item}");
                }
                ConsoleKeyInfo c = Console.ReadKey(true);
                //switch to determind your character
                switch (c.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        exit = true;
                        CharacterObj.Type = CharacterType.Fighter;
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        exit = true;
                        CharacterObj.Type = CharacterType.Mage;
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        exit = true;
                        CharacterObj.Type = CharacterType.Cleric;
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.D4:
                        exit = true;
                        CharacterObj.Type = CharacterType.Bard;
                        break;
                    case ConsoleKey.NumPad5:
                    case ConsoleKey.D5:
                        exit = true;
                        CharacterObj.Type = CharacterType.Rouge;
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D6:
                        exit = true;
                        CharacterObj.Type = CharacterType.Paladin;
                        break;
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.D7:
                        exit = true;
                        CharacterObj.Type = CharacterType.Barbarian;
                        break;
                    case ConsoleKey.NumPad8:
                    case ConsoleKey.D8:
                        exit = true;
                        CharacterObj.Type = CharacterType.Archer;
                        break;
                    case ConsoleKey.NumPad9:
                    case ConsoleKey.D9:
                        exit = true;
                        CharacterObj.Type = CharacterType.Druid;
                        break;
                    default:
                        exit = false;
                        Console.WriteLine("Not a valid Type");
                        Console.ReadKey();
                        break;
                }
            }while (exit == false);

            //Enter your name
            Console.Write("What is your name: ");
            name = Tools.GetInput();
            //The info is stores int the property's of the object
            CharacterObj.Name = name;
            CharacterObj.Level = level;
            CharacterObj.Xp = xp;

            //The Object(your new Character) is added to the party list
            Party.Add(CharacterObj);

            //Character has joined the party
            Console.WriteLine($"{CharacterObj.Name} has joined the party.");
            Console.ReadKey();

            //Returns to menu
            return Party;
        }
    }
}
