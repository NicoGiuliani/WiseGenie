using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseGenie
{
    class Genie
    {
        public static string[] answers = { "I cannot see that answer right now." };

        public static void Answer(Question question)
        {
            Console.WriteLine("\n" + answers[0]);
        }
    }
}
