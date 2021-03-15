using System;

namespace Gnome_Edit
{
    class Program
    {
        private static UserConsole userConsole;
        static void Main(string[] args)
        {
            bool flag = true;
            Console.Clear();
            userConsole = new UserConsole(args[0]);

            userConsole.Display();

            Console.SetCursorPosition(0, 0);
            while(flag)
            {
                userConsole.ReadKey();
            }
            
        }
    }
}