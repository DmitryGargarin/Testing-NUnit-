﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_3__NUnit_
{
    public class TriangleExistsClass
    {
        public bool TriangleExists(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
