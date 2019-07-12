using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseGenie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pose a question
            Question question = new Question();
            Genie.Answer(question);
            Console.ReadLine();
        }
    }
}
