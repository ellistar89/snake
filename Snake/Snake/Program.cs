using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 26);
            Console.SetWindowSize(80, 26);
            Console.CursorVisible = false;

            Walls walls = new Walls(78, 24);
            walls.Draw();
            

            Point p = new Point(4, 5, '@');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator food = new FoodCreator(77,23,'+');
            Point genFood = food.Gen();
            genFood.DrawPoint();


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(genFood))
                {
                    snake.Draw();
                    genFood = food.Gen();
                    genFood.DrawPoint();

                }
                else snake.Move();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo getKey = Console.ReadKey(true);
                    snake.Hanle(getKey.Key);
                }
                Thread.Sleep(100);
            }


        }

    } 



}
