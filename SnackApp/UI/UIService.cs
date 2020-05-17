using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp.UI
{
    public class UIService
    {
		private GamePlay _gamePlay = new GamePlay();

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
			_gamePlay.StartGame();
			Concede();
			//Console.WriteLine("Start Game");
		}

		private void CreateUserForm()
		{
			Console.Clear();
			Console.WriteLine("Create UserForm");
		}

		private void ScoreBoard()
		{
			Console.Clear();
			Console.WriteLine("Create ScoreBoard");
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
