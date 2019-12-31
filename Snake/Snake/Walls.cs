using System.Collections.Generic;

namespace Snake 
{
    class Walls
    {
        List<Figure> wallList = new List<Figure>();
        public Walls(int mapWidth, int mapHeight)
        {
            Horizont topLine = new Horizont(0, mapWidth, 0, '#');
            Horizont botLine = new Horizont(0, mapWidth, mapHeight, '#');
            Vertical leftLine = new Vertical(0, mapHeight, 0, '#');
            Vertical rightLine = new Vertical(0, mapHeight, mapWidth, '#');
            wallList.Add(rightLine);
            wallList.Add(topLine);
            wallList.Add(botLine);
            wallList.Add(leftLine);
        }

        public void Draw()
        {
            foreach (var item in wallList)
            {
                item.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

    }
}