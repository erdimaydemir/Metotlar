﻿using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("erdim");

            Console.WriteLine(isimler);
        }
    }
}
