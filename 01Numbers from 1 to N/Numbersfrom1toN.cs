﻿using System;

class Numbersfrom1toN
{
static void Main()
{
    int n;
        Console.Write("Enter an integer number:");
        bool isnInt = int.TryParse(Console.ReadLine(), out n);
        if (isnInt)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Not a valid entry!");
        }
    }
}


