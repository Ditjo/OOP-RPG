
namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bool used to exit the program
            //A new list is created to hold the party members
            bool exit = true;
            List<CharacterCreator> Party = new();
            //Entering the menu
            do
            {
                Console.Clear();
                Console.WriteLine("*** The Little Console RPG ***\n");
                Console.WriteLine("1. Create New Character");
                Console.WriteLine("2. Show Party");
                Console.WriteLine("3. Role a D6");
                Console.WriteLine("0. Exit");
                ConsoleKeyInfo menu = Console.ReadKey(true);

                //press one of the above mentioned options to acces that method 
                switch (menu.Key)
                {
                    case ConsoleKey.D1:
                        {
                            //Starts the process of making a new character
                            Party = CharacterCreatorGraphics.Player(Party);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            //If no-one has joined the party it can't show the party
                            if (Party.Count == 0)
                            {
                                Console.WriteLine("No members have join the party!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Adventures.PartyMembers(Party);
                            }
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            //Role a D6. Used to test the 6 sided dice method
                            int i = Tools.DiceD6();
                            Console.WriteLine(i);
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.D0:
                        {
                            //exit the program
                            exit = false;
                            break;
                        }
                    default:
                        //Anything else & it's not valid
                        Console.Clear();
                        Console.WriteLine("Not Valid Input");
                        Console.WriteLine("Press any key to return");
                        Console.ReadKey();
                        break;
                }
            } while (exit);

        }
    }
}