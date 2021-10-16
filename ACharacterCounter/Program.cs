using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees- ja perekonnanime
            //programm kuvab, mitu "a" tahte on on kasutaja ees- ja perekonnanimes kokkus

            Console.WriteLine("Sisesta eesnimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            string lastName = Console.ReadLine();

            string  fullName = $"{firstName}{lastName}".ToLower();

            int aCounter = 0;

            for(int i = 0; i < fullName.Length; i++)
            {
               if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if (aCounter !=1)
            {
                Console.WriteLine($"Sinus taisnimes on {aCounter} 'a' tahte.");
            }
            else
            {
                Console.WriteLine($"Sinu taisnimes on {aCounter} 'a' taht");
            }


        }
    }
}
