using System;
using System.Threading;
using SnackApp.Factory;
using SnackApp.Helpers;
using SnackApp.Installers;

namespace SnackApp
{
    public class GamePlay
    {
        public static void StartGame()
        {
            int score = 0;

            var lineInstallers = new LineInstaller();
            lineInstallers.DrawShapes();

            var food = FoodFactory.GetRandomFood(70, 20, '+');
            Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 4));
            food.DrawPoint();
            Console.ResetColor();

            var snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, '8'), Enums.DirectionEnum.Right);
            snake.DrawLine();

            ScoreHelper.GetScore(score);

            while (true)
            {
                if (lineInstallers.Collision(snake) || snake.CollisionOnTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    score++;
                    ScoreHelper.GetScore(score);

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
