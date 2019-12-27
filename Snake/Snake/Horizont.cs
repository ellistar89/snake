using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Horizont
    {
        List<Point> pointList = new List<Point>();
        public Horizont(int xleft, int xright, int y , char sym)
        {
            for (int i = xleft; i < xright; i++)
            {
                Point p = new Point(i, y, sym);
                pointList.Add(p);
            }
        }

        public void DrawLine()
        {
            foreach (var item in pointList)
            {
                item.Draw();
            }
        }
    }
}
