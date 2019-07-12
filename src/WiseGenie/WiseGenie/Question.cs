using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiseGenie
{
    class Question
    {
        private string _sentence;
        private string _answer = null;
        private string[] _genericAnswers =
        {
            "I cannot see that answer right now.",
            // add more possible answers later
        };

        public Question()
        {
            Console.WriteLine("Ask your question by typing, \"Tell me wise genie, \".");
            Console.Write(":: ");

            
        }

    }
}
