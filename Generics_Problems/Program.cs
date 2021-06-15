using System;

namespace Generics_Problems
{
    class Program
    { 
        static void Main(string[] args)
        {
            ThreeVariablesMaximumNumber maxnumber = new ThreeVariablesMaximumNumber();
            int maxintnumber = maxnumber.checkMaximumNum(10, 20, 35);  // Passing Input's
            Console.WriteLine(maxintnumber);
        }

    }
}
