using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Dont Panic" nulliga - 0
            //programm asendab koik 'a' tahed samas lauses 4-ga

            string lause = "Don't Panic!";

            lause = lause.Replace('o', '0');
            lause = lause.Replace('a', '4');

            Console.WriteLine(lause);
        }
    }
}
