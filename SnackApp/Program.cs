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
using SnackApp.UI;

namespace SnackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var uiService = new UIService();
            uiService.GetMenu();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                uiService.GetCommand(key.Key);

            }
        }
    }
}
