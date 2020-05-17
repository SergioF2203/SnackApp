using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackApp.Enums;

namespace SnackApp
{
    public class Snake : Shape
    {
        DirectionEnum _direction;
        public Snake()
        {
            _points = new List<Point>();
        }
        public Snake CreateSnake(int length, Point snakeTail, DirectionEnum direction)
        {
            _direction = direction;
            for (int i = 0; i < length; i++)
            {
                var point = new Point(snakeTail);
                point.SetDirection(i, direction);
                _points.Add(point);
            }
            return new Snake();
        }

        public void Move()
        {
            var tail = _points.First();
            _points.Remove(tail);

            var head = new Point(_points.Last());
            head.SetDirection(1, _direction);
            _points.Add(head);

            tail.ClearPoint();
            head.DrawPoint();
        }

        public void PressKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = DirectionEnum.Left;
            else if (key == ConsoleKey.RightArrow)
                _direction = DirectionEnum.Right;
            else if (key == ConsoleKey.UpArrow)
                _direction = DirectionEnum.Up;
            else if (key == ConsoleKey.DownArrow)
                _direction = DirectionEnum.Down;
        }

        public bool Eat(Point food)
        {
            var head = new Point(_points.Last());
            head.SetDirection(1, _direction);

            if (head.ComparePoints(food))
            {
                food.Symbol = head.Symbol;
                _points.Add(head);
                return true;
            }

            return false;
        }
    }
}
