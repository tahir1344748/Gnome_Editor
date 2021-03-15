using System;

namespace Gnome_Edit
{
    class UserConsole
    {
        private Stream inputStream;
        private static int _ConsoleColumn;
        private static int _ConsoleRow;

        public UserConsole(string argsFileName)
        {
            inputStream = new Stream(argsFileName);
            _ConsoleColumn = 0;
            _ConsoleRow = 0;
        }

        public int ConsoleColumn
        {
            set
            {
                _ConsoleColumn = value;
            }
            get
            {
                return _ConsoleColumn;
            }
        }

        public int ConsoleRow
        {
            set
            {
                _ConsoleRow = value;
            }
            get
            {
                return _ConsoleRow;
            }
        }
        public void ReadKey()
        {
            ConsoleKeyInfo inputKey = Console.ReadKey();

            if(inputKey.Key == ConsoleKey.DownArrow)
            {
                _ConsoleRow++;
                Console.SetCursorPosition(_ConsoleColumn, _ConsoleRow);
                return;
            }
            else if(inputKey.Key == ConsoleKey.UpArrow)
            {
                if(_ConsoleRow == 0)
                {
                    Console.SetCursorPosition(0, 0);
                }
                else
                {
                    _ConsoleRow--;
                    Console.SetCursorPosition(_ConsoleColumn, _ConsoleRow);
                    return;
                }
            }
            else if(inputKey.Key == ConsoleKey.LeftArrow)
            {
                if(_ConsoleColumn > 0)
                {
                    _ConsoleColumn--;
                    Console.SetCursorPosition(_ConsoleColumn, _ConsoleRow);
                    return;
                }
                else{
                    if(_ConsoleRow == 0)
                    {
                        Console.SetCursorPosition(_ConsoleColumn, _ConsoleRow);
                    }
                    else
                    {
                        _ConsoleRow--;
                        Console.SetCursorPosition(_ConsoleColumn, _ConsoleRow);
                        return;
                    }
                }
            }
            else if(inputKey.Key == ConsoleKey.RightArrow)
            {
                _ConsoleColumn++;
                Console.SetCursorPosition(_ConsoleColumn, _ConsoleRow);
                return;
            }
            else if(inputKey.Key == ConsoleKey.Escape)
            {
                //exits the program; terminates the program
                Environment.Exit(0);
                return;
            }
            else if(inputKey.Modifiers.HasFlag(ConsoleModifiers.Control) &&  Console.ReadKey().Key == ConsoleKey.S)
            {
                    Console.Clear();
                    return;
            }
        }

        public void Display()
        {
            foreach(string line in inputStream.InputStream)
            {
                foreach(char ch in line)
                {
                    if(ch=='#')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if(ch=='<')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if(ch==' ')
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine('\n');
                }

                Console.Write(ch);
                }
            }
            //foreach(string alpha in inputStream.InputStream)
            //{
            //    Console.WriteLine(alpha);
            //}
        }
    }
}