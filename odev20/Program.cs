﻿using System;

namespace or259
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s, ys = "";
            int a;
            byte c;

            Console.Write("Bir cümle giriniz:");
            s = Console.ReadLine();

            for (a = 0; a < s.Length; a++)
            {
                c = (byte)s[a];

                if (c >= 65 && c <= 90) // büyük harf ise
                {
                    ys = ys + (char)(c + 32); // ASCII kodu tekrar karaktere dönüştürülüyor!
                }
                else
                {
                    ys = ys + s[a];
                }
            }

            Console.WriteLine(ys);
            Console.WriteLine("\n\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}