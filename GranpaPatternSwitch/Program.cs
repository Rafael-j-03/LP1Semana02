using System;

namespace GranpaPatternSwitch
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Place your question? ");
            string question = Console.ReadLine();

            string response = question switch
            {
                "How are you?" => "I'm fine, thank you",
                "What's your name?" => "Gran'pa",
                "What's your mission?" => "Destroy mankind!",
                _ => "You got me, I'm not THAT smart!",
            };

            Console.WriteLine(response);
        }
    }
}
