﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokunHW8
{
    public class Circle : Shape
    {

        private double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public double Radius { get { return radius; } set { radius = value; } }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

    }
}
