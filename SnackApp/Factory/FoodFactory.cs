using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp.Factory
{
    public static class FoodFactory
    {
        static Random _random = new Random();
        public static Point GetRandomFood(int spaceWidth, int spaceHeight, char symbol)
        {
            spaceWidth = _random.Next(1, spaceWidth - 2);
            spaceHeight = _random.Next(1, spaceHeight - 2);

            return new Point(spaceWidth, spaceHeight, symbol);
        }
    }
}
