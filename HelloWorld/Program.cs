using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Start();
            // Console.WriteLine("Welcome to the MultiPlex 2000!");
            // Console.WriteLine("Who's bot would you like to talk to?");
            // var response = Console.ReadLine();
            // if (response.ToLower() == "makiah")
            // {
            //     TalkToMakiah();
            // }
            // else if (response.ToLower() == "aylah")
            // {
            //     TalkToAylah();
            // }
            // else if (response.ToLower() == "elliot")
            // {
            //     TalkToElliot();
            // }
            // else if (response.ToLower() == "michael")
            // {
            //     TalkToMichael();
            // }
            // else
            // {
            //     Console.WriteLine($"Sorry, no bots by the name {response} here!");	
            // }
        }

        static void TalkToMakiah()
        {
            Console.WriteLine("Hello, this is Makiah's Bot.");
            var bot = new MakiahBot();
            bot.Start();
        }

        static void TalkToAylah()
        {
            Console.WriteLine("Hello, this is Aylah's Bot.");
            var bot = new AylahBot();
            bot.Start();
        }

        static void TalkToElliot()
        {
            Console.WriteLine("Hello, this is Elliot's Bot.");
            var bot = new ElliotBot();
            bot.Start();
        }

        static void TalkToMichael()
        {
            Console.WriteLine("Hello, this is Michael's Bot.");
            var bot = new MichaelBot();
            bot.Start();
        }
    }
}
