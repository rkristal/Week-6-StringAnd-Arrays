﻿using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

           // int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length}  sumbolit.");
        }
    }
}
