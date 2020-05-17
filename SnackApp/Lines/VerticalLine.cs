using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp.Lines
{
    public class VerticalLine : Shape
    {

        public VerticalLine(int left, int top, int count, char symbol)
        {
            _points = new List<Point>();

            for (int i = top; i < count; i++)
            {
                var point = new Point(left, i, symbol);
                _points.Add(point);
            }
        }

    }
}
