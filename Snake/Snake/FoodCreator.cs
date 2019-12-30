using System;

namespace Snake
{
    class FoodCreator
    {
        int consoleWidght;
        int consoleHight;
        char sym; 

        Random random = new Random();
        public FoodCreator(int consoleWidght,int consoleHight, char sym)
        {
            this.consoleHight = consoleHight;
            this.consoleWidght = consoleWidght;
            this.sym = sym;
        }

        public Point Gen()
        {
            int x = random.Next(1, consoleWidght);
            int y = random.Next(1, consoleHight);
            Point food = new Point(x, y, sym);
            return food;
        }
    }
}