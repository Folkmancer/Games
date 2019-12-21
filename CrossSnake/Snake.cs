using System;
using System.Collections.Generic;
using System.Text;

namespace CrossSnake
{
    class Snake
    {
        List<Point> points;
        public Snake(Point tail, int length, Direction direction)
        {
            points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.Move(i, direction);
                points.Add(point);
            }
        }
    }
}
