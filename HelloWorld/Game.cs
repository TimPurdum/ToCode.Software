using System;
using System.Threading;

namespace HelloWorld
{
    public class Game
    {
        public void Start()
        {
            while (true)
            {
                GetData();
            }
        }


        public void GetData()
        {
            // a question or statement
            Console.WriteLine("What do you want to do?");

            // user gives input
            var response = Console.ReadLine();

            if (response == "room")
            {
                var room = new Room();
                room.WelcomeMessage = "You enter a small, dark room.";
                Console.WriteLine(room.WelcomeMessage);
            }
            // do something with the response
            Console.WriteLine("Really? I want to do that too.");

            Thread.Sleep(4000);
        }
    }
}