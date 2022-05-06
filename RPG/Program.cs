
namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            List<CharacterCreator> Party = new();
            do
            {
                Console.Clear();
                Console.WriteLine("*** The Little Console RPG ***\n");
                Console.WriteLine("1. Create New Character");
                Console.WriteLine("2. Show Party");
                Console.WriteLine("3. Role a D6");
                Console.WriteLine("0. Exit");
                ConsoleKeyInfo menu = Console.ReadKey(true);

                switch (menu.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Party = CharacterCreatorGraphics.Player(Party);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
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
                            int i = Tools.DiceD6();
                            Console.WriteLine(i);
                            Console.ReadKey();
                            break;
                        }
                    case ConsoleKey.D0:
                        {
                            exit = false;
                            break;
                        }
                    default:
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