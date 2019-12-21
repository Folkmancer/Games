using System;
using System.Collections.Generic;
using System.Text;

namespace CrossSnake
{
    class Line
    {
        List<Point> points;

        public Line()
        {
            points = new List<Point>();
        }

        public void AddHorizontalLine(int left, int right, int posY, char sym)
        {
            for (int posX = left; posX < right; posX++)
            {
                points.Add(new Point(posX, posY, sym));
            }  
        }

        public void AddVerticalLine(int posX, int up, int down, char sym)
        {
            for (int posY = up; posY < down; posY++)
            {
                points.Add(new Point(posX, posY, sym));
            }
        }

        public void Draw()
        {
            foreach (Point point in points)
            {
                point.Draw();
            }
        }
    }
}
