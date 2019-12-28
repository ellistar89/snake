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

            Console.SetBufferSize(120, 30 );

            Horizont topLine = new Horizont(0, 78, 0, '#');
            Horizont botLine = new Horizont(0, 78, 24, '#');
            Vertical leftLine = new Vertical(0, 24, 0, '#');
            Vertical rightLine = new Vertical(0, 24, 78, '#');
            rightLine.DrawLine();
            topLine.DrawLine();
            botLine.DrawLine();
            leftLine.DrawLine();

            Point p = new Point(4, 5, '^');
            p.Draw();

            Console.ReadLine();
        }

    } 



}
