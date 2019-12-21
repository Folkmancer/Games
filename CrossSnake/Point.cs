using System;
using System.Collections.Generic;
using System.Text;

namespace CrossSnake
{
    class Point
    {
        private int positionX;
        private int positionY;
        private int symbol;

        public Point(int x, int y, int sym)
        {
            positionX = x;
            positionY = y;
            symbol = sym;
        }

        public Point(Point point)
        {
            positionX = point.positionX;
            positionY = point.positionY;
            symbol = point.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.Left) positionX -= offset;
            else if (direction == Direction.Right) positionX += offset;
            else if (direction == Direction.Up) positionY += offset;
            else if (direction == Direction.Down) positionY -= offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
        }
    }
}
