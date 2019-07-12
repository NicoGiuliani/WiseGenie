using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsInput;
using WindowsInput.Native;

namespace WiseGenie
{
    class Question
    {
        public string Answer { get; set; } = null;
        private string[] _sentence = {"T", "e", "l", "l", " ", "m", "e", " ", "w", "i", "s", "e", " ", "g", "e", "n", "i", "e", ",", " "};
        private int _index = 0;
        

        public Question()
        {
            Console.WriteLine("Ask your question by typing, \"Tell me wise genie, \".\n");
            Console.Write(":: ");

            // Captures the first key's information to determine what to do next
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            ConsoleKeyInfo cki;

            // If the period key is pressed first, access this mode
            if (keyInfo.Key == ConsoleKey.OemPeriod)
            {
                // Hidden mode
                while (_index < _sentence.Length)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Backspace)
                    {
                        Console.Write("\b" + " " + "\b"); 
                        if (_index - 1 >= 0)
                        {
                            _index--;
                        }
                        
                    }
                    else
                    {
                        Answer += cki.KeyChar;
                        Console.Write(_sentence[_index++].ToString());
                    }
                    
                    
                }

                Console.ReadLine();
            }


            // Otherwise resume normal function
            else
            {
                Console.Write(keyInfo.KeyChar);
                _index++;

                bool marker = true;

                while (marker)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Backspace)
                    {
                        
                        if (_index > 0)
                        {
                            Console.Write("\b" + " " + "\b");
                            _index--;
                        }
                        
                    }
                    else
                    {
                        Console.Write(cki.KeyChar);
                        _index++;
                    }
                    
                }
                

                





                Console.ReadLine();
            }

            Console.WriteLine();



        }

    }
}
