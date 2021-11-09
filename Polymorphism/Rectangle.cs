﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Rectangle : Drawing
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 4;
            Height = 5;
        }

        public override double Area()
        {
            double area = Width * Height;

            Console.WriteLine("Rektangelns area är :" + area);

            return area;
        }
    }
}
