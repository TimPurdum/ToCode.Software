using System;

namespace HelloWorld
{
    public class TimBot
    {
        public void Start()
        {
            Console.WriteLine("Hello from TimBot.");
            Console.WriteLine("Why did you wake me up?");
            var response = Console.ReadLine();
            Console.WriteLine($"{response} is not a good reason.");
        }
    }
}
