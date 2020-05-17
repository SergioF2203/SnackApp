using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SnackApp.Enums;

namespace SnackApp
{
    public class Point
    {
        int _left;
        int _top;
        char _symbol;

        public char Symbol { get; set; }

        public Point(Point snakeTail)
        {
            _left = snakeTail._left;
            _top = snakeTail._top;
            _symbol = snakeTail._symbol;
        }

        public void SetDirection(int i, DirectionEnum direction)
        {
            switch (direction)
            {
                case DirectionEnum.Right:
                    _left += i;
                    break;
                case DirectionEnum.Left:
                    _left -= i;
                    break;
                case DirectionEnum.Up:
                    _top -= i;
                    break;
                case DirectionEnum.Down:
                    _top += i;
                    break;
            }
        }

        internal void ClearPoint()
        {
            _symbol = ' ';
            DrawPoint();
        }

        public Point(int left, int top, char symbol)
        {
            _left = left;
            _top = top;
            _symbol = symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(_left, _top);
            Console.WriteLine(_symbol);
        }

        public bool ComparePoints(Point point)
        {
            return (point._left == _left && point._top == _top);
        }

        //public static bool operator ==(Point point1, Point point2)
        //{
        //    return (point1._left == point2._left && point1._top == point2._top);
        //}

        //public static bool operator !=(Point point1, Point point2)
        //{
        //    return (point1._left == point2._left || point1._top == point2._top);
        //}

    }
}
