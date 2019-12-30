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

        public void Hanle(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow && direction != Direction.RIGHT) direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow && direction != Direction.LEFT) direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow && direction != Direction.UP) direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow && direction != Direction.DOWN) direction = Direction.UP;
            
        }

        internal bool Eat (Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pointList.Add(food);
                return true;

            }
            else return false;
        }
    }
}
