using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SnackApp.Factory;
using SnackApp.Helpers;
using SnackApp.Installers;
using SnackApp.Lines;

namespace SnackApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var lineInstallers = new LineInstaller();
            lineInstallers.DrawShapes();

            var food = FoodFactory.GetRandomFood(70, 20, '+');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 4));
            food.DrawPoint();
            Console.ResetColor();

            var snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, '8'), Enums.DirectionEnum.Right);
            snake.DrawLine();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = FoodFactory.GetRandomFood(70, 20, '+');
                    Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 4));
                    food.DrawPoint();
                    Console.ResetColor();
                }

                Thread.Sleep(100);
                snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PressKey(key.Key);
                }
            }



        }
    }
}
