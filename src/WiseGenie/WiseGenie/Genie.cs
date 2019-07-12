using System;

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

        public static void ShowLamp()
        {
            Console.WriteLine("\n                                          ..\n" +
                              "                                         dP/$.\n" +
                              "                                         $4$$%\n" +
                              "                                       .ee$$ee.\n" +
                              "                                    .eF3??????$C$r.        .d$$$$$$$$$$$e.\n" +
                              " .zeez$$$$$be..                    JP3F$5'$5K$?K?Je$.     d$$$FCLze.CC?$$$e\n" +
                              "     \"\"\" ??$$$$$$$$ee..         .e$$$e$CC$???$$CC3e$$$$.  $$$/$$$$$$$$$.$$$$\n" +
                              "            `\" ?$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$b $$\"$$$$P?CCe$$$$$F\n" +
                              "                 \" ?$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$b$$J ? bd$$$$$$$$$F\"\n" +
                              "                     \"$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$d$$F\"\n" +
                              "                        \" ?$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$\"...\n" +
                              "                            \" ?$$$$$$$$$$$$$$$$$$$$$$$$$F \"$$\"$$$$b\n" +
                              "                                \" ?$$$$$$$$$$$$$$$$$$F\"     ?$$$$$F\n" +
                              "                                     \"\"????????C\"\n" +
                              "                                     e$$$$$$$$$$$$.\n" +
                              "                                   .$b CC$????$$F3eF\n" +
                              "                                 4$bC/%$bdd$b@$Pd??Jbbr\n" +
                              "                                   \"\"?$$$$eeee$$$$F?\"\n");
        }
    }
}
