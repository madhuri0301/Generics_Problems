using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problems
{
    public class ThreeVariablesMaximumNumber
    {
        public int checkMaximumNum(int x, int y, int z)  //passing parameters 

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
        public float checkMaximumNum(float x, float y, float z) //passing parameters 
        {
            float max = x;
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
