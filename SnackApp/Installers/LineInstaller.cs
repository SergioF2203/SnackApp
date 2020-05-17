using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp.Installers
{
    public class LineInstaller
    {
        List<Shape> _shapes;

        public LineInstaller()
        {
            _shapes = new List<Shape>();
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
