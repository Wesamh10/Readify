using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using knockknock.readify.net;

namespace ReadifyServiceApplication.Managers
{
    public class ShapesManager
    {
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {

            if (a <= 0 || b <= 0 || c <= 0)
            {
                // check if any side is 0
                return TriangleType.Error;
            }
            else if ((a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                // check if Sides can connect 
                return TriangleType.Error;
            }
            if (a == b && a == c)
            {
                // all sides are equal
                return TriangleType.Equilateral;
            }
            else if (a == b || a == c || b == c)
            {
                // two sides only are equal
                return TriangleType.Isosceles;
            }
            else
            {
                // three sides are different
                return TriangleType.Scalene;
            }
        }
    }
}