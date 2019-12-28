﻿using System;
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

            Horizont topLine = new Horizont(0, 78, 0, '#');
            Horizont botLine = new Horizont(0, 78, 24, '#');
            Vertical leftLine = new Vertical(0, 24, 0, '#');
            Vertical rightLine = new Vertical(0, 24, 78, '#');
            rightLine.Draw();
            topLine.Draw();
            botLine.Draw();
            leftLine.Draw();

            Point p = new Point(4, 5, '^');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300); snake.Move();
            Thread.Sleep(300);
            Console.ReadLine();
        }

    } 



}
