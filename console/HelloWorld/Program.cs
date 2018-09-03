using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateWelcomeMessage());
        }

        public static string CreateWelcomeMessage() => "Hello World! --NG";
    }
}
