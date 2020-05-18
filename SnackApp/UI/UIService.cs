using System;
using SnackApp.UserServices;

namespace SnackApp.UI
{
    public class UIService
    {
        private GamePlay _gamePlay = new GamePlay();
        private UserService _userservice = new UserServices.UserService();
        private User _user = new User();

        public void GetMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("||=======================================================||");
            Console.SetCursorPosition(30, 6);
            Console.WriteLine("||-------------------------------------------------------||");
            Console.SetCursorPosition(30, 7);
            Console.WriteLine("|| -------------- Welcome to snake game ---------------- ||");
            Console.SetCursorPosition(30, 8);
            Console.WriteLine("||-------------------------------------------------------||");
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("||=======================================================||");
            Console.SetCursorPosition(30, 11);
            Console.WriteLine("             - Press Enter to start the game               ");
            Console.SetCursorPosition(30, 13);
            Console.WriteLine("             - Use arrows to move the snake                ");
            Console.SetCursorPosition(30, 14);
            Console.WriteLine("             - Press C to create the user                  ");
            Console.SetCursorPosition(30, 15);
            Console.WriteLine("             - Press S to get all scores                   ");
            Console.SetCursorPosition(30, 16);
            Console.WriteLine("             - Press ESC to quite the game                 ");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("||-------------------------------------------------------||");
            Console.SetCursorPosition(30, 18);
            Console.WriteLine("||=======================================================||");

        }

        public void GetCommand(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    StartGame();
                    break;
                case ConsoleKey.C:
                    CreateUserForm();
                    break;
                case ConsoleKey.S:
                    ScoreBoard();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    GetMenu();
                    break;

            }
        }

        private void StartGame()
        {
            Console.Clear();
            _gamePlay.StartGame(_user);
            Concede();
        }

        private void CreateUserForm()
        {
            Console.Clear();

        Label:
            Console.Write("Enter your Name, please: ");
            var userName = Console.ReadLine();

            try
            {
                _user = _userservice.CreateUser(userName);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Label;
            }

            Console.WriteLine("save");
            Console.WriteLine("DS to menu");
        }

        private void ScoreBoard()
        {
            Console.Clear();
            var users = _userservice.GetAllUsers();
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Name}, score: {item.Score}");
            }

            Console.WriteLine("Press BS to menu");
        }

        private void Concede()
        {
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.WriteLine("To try game press Enter");
            Console.WriteLine("Back to menu BS");
        }
    }
}
