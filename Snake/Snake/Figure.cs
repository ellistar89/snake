using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pointList = new List<Point>();
        public void Draw()
        {
            foreach (var item in pointList)
            {
                item.DrawPoint();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var item in pointList)
            {
                if (figure.IsHit(item))
                {
                    return true;
                }
            }
            return false;
        }
        internal bool IsHit(Point point)
        {
            foreach (var p in pointList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
