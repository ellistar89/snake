using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length,Direction direction)
        {
            pointList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                this.direction = direction;
                Point p = new Point(tail);
                p.Move(i, this.direction);
                pointList.Add(p);
                
            }
        }

        internal void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            Point head = GetNextPoint();
            pointList.Add(head);

            tail.Clean();
            head.DrawPoint();
        }

        public Point GetNextPoint()
        {
            Point head = pointList.Last();
            Point nextHead = new Point(head);
            nextHead.Move( 1 , this.direction);
            return nextHead;
        }
    }
}
