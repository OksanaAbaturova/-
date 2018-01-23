﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcConsole
{
   public class Calc
    {
        public double Sum (double x, double y)
        {
            return x+y;
        }
        public double Sub(double x, double y)
        {
            return x-y;
        }
        public double Multi(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
        public double Sqrt(double x)
        {
            return (long)Math.Round(Math.Sqrt(x));
        }
        public double Pow(double x, double y)
        {
            return (long)Math.Pow(x, y);
        }
    }
}