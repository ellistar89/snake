using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.ReadLine();
        }
        static void Drow(int x, int y , char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

    }



}
