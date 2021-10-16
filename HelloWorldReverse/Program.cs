using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
           //programm kuvab Hello World! tagurpidi
           
            
            for (int i = "Hello World!".Length -1; i >= 0; i--)
            {
                Console.Write("Hello World!"[i]);
            }
        }
    }
}
