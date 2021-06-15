using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Generics_Problems;
namespace TestMaximumNumber
{
    public class Tests
    {
        ThreeVariablesMaximumNumber maximum = new ThreeVariablesMaximumNumber();
        [Test]
        public void Given_Max_Number_at_1st_Position_return_the_Same_Number()
        {
            int maximumResult = maximum.checkMaximumNum(5, 4, 3);
            AssertionException.Equals(5, maximumResult);
        }
        [Test]
        public void Given_Max_Number_at_2nd_Position_return_the_Same_Number()
        {
            int maximumResult = maximum.checkMaximumNum(4, 5, 3);
            AssertionException.Equals(5, maximumResult);
        }
        [Test]
        public void Given_Max_Number_at_3rd_Position_return_the_Same_Number()
        {
            int maximumResult = maximum.checkMaximumNum(3, 4, 5);
            AssertionException.Equals(5, maximumResult);
        }

    }
}