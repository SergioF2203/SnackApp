using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackApp.Lines;

namespace SnackApp.Installers
{
    public class LineInstaller
    {
        List<Shape> _shapes;

        public LineInstaller()
        {
            _shapes = new List<Shape>();

            var horizontalUpLine = new HorizontalLine(0, 0, 70, '-');
            var horizontalDownLine = new HorizontalLine(0, 20, 70, '-');

            var verticalLeftLine = new VerticalLine(0, 1, 20, '|');
            var verticalRightLine = new VerticalLine(69, 1, 20, '|');

            _shapes.AddRange(new List<Shape> { horizontalUpLine, horizontalDownLine, verticalLeftLine, verticalRightLine });
        }

        public void DrawShapes()
        {
            foreach (var line in _shapes)
            {
                line.DrawLine();
            }
        }
    }
}
