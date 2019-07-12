using System;

namespace WiseGenie
{
    class Question
    {
        public string Answer { get; set; } = null;
        private string _backspace = "\b" + " " + "\b";
        private string _sentence = "Tell me wise genie, ";
        private int _index = 0;
        private ConsoleKeyInfo keyInfo;
        private ConsoleKeyInfo cki;
        

        public Question()
        {
            Console.WriteLine("Ask your question by typing, \"Tell me wise genie, \".\n");
            Console.Write(":: ");

            // Captures the first key's information to determine what to do next
            keyInfo = Console.ReadKey(true);

            // If the period key is pressed first, access hidden mode
            if (keyInfo.Key == ConsoleKey.OemPeriod)
            {
                while (_index < _sentence.Length)
                {
                    cki = Console.ReadKey(true);

                    // Allows backspacing
                    if (cki.Key == ConsoleKey.Backspace)
                    {
                        if (_index > 0)
                        {
                            Answer += _backspace;
                            _index--;
                            Console.Write(_backspace);
                        }
                    }
                    // A second period will exit hidden mode
                    else if (cki.Key == ConsoleKey.OemPeriod)
                    {
                        break;
                    }
                    // Appends the key pressed to the answer
                    else
                    {
                        Answer += cki.KeyChar;
                        Console.Write(_sentence[_index++].ToString());
                    }
                    
                }

                Console.ReadLine();
            }

            // Otherwise continue in normal mode
            else
            {
                if (keyInfo.Key != ConsoleKey.Backspace)
                {
                    Console.Write(keyInfo.KeyChar);
                    _index++;
                }
                
                while (true)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Backspace)
                    {
                        if (_index > 0)
                        {
                            Console.Write(_backspace);
                            _index--;
                        }                  
                    }
                    else if (cki.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(cki.KeyChar);
                        _index++;
                    }
                    
                }
                  
            }

            Console.WriteLine();
        }

    }
}
