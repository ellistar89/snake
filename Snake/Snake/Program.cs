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

            Horizont topLine = new Horizont(0, Console.WindowWidth, 0, '#');
            Horizont botLine = new Horizont(0, Console.WindowWidth, Console.WindowHeight - 1, '#');
            Vertical leftLine = new Vertical(0, Console.WindowHeight - 1, 0, '#');
            Vertical rightLine = new Vertical(0, Console.WindowHeight - 1, Console.WindowWidth - 1, '#');
            rightLine.DrawLine();
            topLine.DrawLine();
            botLine.DrawLine();
            leftLine.DrawLine();

            Console.ReadLine();
        }

    }



}
