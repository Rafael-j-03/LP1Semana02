using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Place your question: ");
                string input = Console.ReadLine();

                string response = input switch
                {
                    "How are you?" => "I'm fine, thank you!",
                    "What's your name?" => "Mother",
                    "What's your mission?" => "Make the world better!",
                    "What day is it?" => "One day more than yesterday",
                    _ => "You got me, I don't know what to answer!",
                };

                Console.WriteLine(response);
            }
        }
    }
}
