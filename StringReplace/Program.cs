using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Hello World!" tarniga(*)

            string helloW = "Hello World!";

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', 'l');

            Console.WriteLine(helloW);
        }
    }
}
