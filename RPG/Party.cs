using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Adventures
    {
        static internal void PartyMembers(List<CharacterCreator> Party)
        {
            foreach (var item in Party)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"{item.Name} the {item.Type}");
                Console.WriteLine($"Strength: {item.Strength}");
                Console.WriteLine($"Agility: {item.Agility}");
                Console.WriteLine($"Smarts: {item.Smarts}");
                Console.WriteLine($"Magic: {item.Magic}\n");
                Console.WriteLine($"Level: {item.Level}");
                Console.WriteLine($"Xp: {item.Xp}");
            }
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Press any key to return to menu....");
            Console.ReadKey();
        }
    }
}
