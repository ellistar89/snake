using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Horizont : Figure
    {

        public Horizont(int xleft, int xright, int y , char sym)
        {
            for (int i = xleft; i <= xright; i++)
            {
                Point p = new Point(i, y, sym);
                pointList.Add(p);
            }
        }


    }
}
