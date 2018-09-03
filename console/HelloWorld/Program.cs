using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateWelcomeMssage());
        }

        public static string CreateWelcomeMssage() => "Hello World! --NG";

        public static double Calculater(double a, double b, string op) {
            if (op == "add")
            {
                return a + b;
            }
            else
                throw new InvalidOperationException ("Operation not defined");
        }
    }
}
