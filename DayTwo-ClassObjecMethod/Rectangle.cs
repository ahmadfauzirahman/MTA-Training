﻿using System;

namespace DayTwo_ClassObjecMethod
{
    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            this.length = l;
            this.width = w;
        }
        public double GetArea()
        {
            return this.width * this.length;
        }
    }
}