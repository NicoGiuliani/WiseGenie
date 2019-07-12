using System;

namespace WiseGenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Genie.ShowLamp();

            // Pose a question, then pass it to the Genie
            Question question = new Question();
            Genie.Answer(question);
            Console.ReadLine();
        }
    }
}
