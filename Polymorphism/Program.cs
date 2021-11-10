﻿using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing s1 = new Square();
            Console.WriteLine(s1.Area()); 

            Drawing c1 = new Circle();
            Console.WriteLine(c1.Area());

            Drawing r1 = new Rectangle();
            Console.WriteLine(r1.Area());
        }
    }
}
