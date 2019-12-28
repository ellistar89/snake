using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vertical : Figure
    {
        public Vertical(int yTop, int yBot, int x , char sym)
        {
            for (int i = yTop; i <= yBot; i++)
            {
                Point p = new Point(x, i, sym);
                pointList.Add(p);
            }
        }

    }
}
