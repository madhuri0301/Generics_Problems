﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problems
{
    public class ThreeVariablesMaximumNumber
    {
        public int checkMaximumNum(int x, int y, int z)

        {
            int max = x;
            if (y.CompareTo(max) > 0)
            {
                max = y; // y is largest
            }
            if (z.CompareTo(max) > 0)
            {
                max = z; // z is largest
            }
            return max;
        }
    }
}