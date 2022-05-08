using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Tools
    {
        //Get's input & makes sure it's not empty or null
        static internal string GetInput()
        {
            string? input;
            do
            {
                ValueTuple<int, int> f = Console.GetCursorPosition();
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    //used to tell you it's the wrong input &
                    //delete that specific feedback after you have acknowledge it. 
                    //ValueTuple can store 2 inputs from GetCursorPosition
                    ValueTuple<int, int> d = Console.GetCursorPosition();
                    Console.Write("Invalid Input");
                    Console.ReadKey();
                    Console.SetCursorPosition(d.Item1, d.Item2);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(f.Item1, f.Item2);
                }
            } while (string.IsNullOrEmpty(input));
            return input;
        }
        //D6 Dice
        static internal int DiceD6()
        {
            Random D6 = new Random();
            int i = D6.Next(1, 7);
            return i;
        }
        //Roling 3 X D6 dice & adds the together
        static internal int RoleD6(int num)
        {
            int role = 0;
            for (int i = 0; i < num; i++)
            {
                role = DiceD6() + DiceD6() + DiceD6();
            }
            return role;
        }
    }
}
