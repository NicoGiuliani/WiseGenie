using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseGenie
{
    class Genie
    {
        private static string[] answers = { "I cannot see that answer right now." };

        public static void Answer(Question question)
        {
            if (question.Answer != null)
            {
                Console.WriteLine(question.Answer);
                return;
            }
            Console.WriteLine("\n" + answers[0]);
        }
    }
}
