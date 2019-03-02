using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarTestRules;

namespace WarTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WarTest wartest = new WarTest();            
            while (true)
            {
                Console.WriteLine(wartest.fen);
                Print(WarToAscii(wartest));
                string move = Console.ReadLine();
                if (move == "") break;
                wartest = wartest.Move(move);
            }
        }

        static string WarToAscii (WarTest wartest)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" +-------------------+");

            for (int x = 8; x>= 0; x--)
            {
                sb.Append(x+1);                
                    sb.Append("| ");
                for (int y = 0; y < 9; y++)                
                        sb.Append(wartest.GetFigureAt(x, y) + " ");                
                sb.AppendLine("|");
            }
            sb.AppendLine(" +-------------------+");
            sb.AppendLine("   a b c d e f g h i  ");
            return sb.ToString();
        }

        static void Print (string text)
        {
            ConsoleColor old = Console.ForegroundColor;
            foreach (char x in text)
            {
                if (x >= 'a' && x <= 'z')
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (x >= 'A' && x <= 'Z')
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(x);
                
            }
            Console.ForegroundColor = old;
        }
    }
}
