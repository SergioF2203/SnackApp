using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnackApp.Lines;

namespace SnackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var horizontalLine = new HorizontalLine(0, 0, 120, '*');
            horizontalLine.DrawLine();
        }
    }
}
