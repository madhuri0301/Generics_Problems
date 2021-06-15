using System;

namespace Generics_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeVariablesMaximumNumber maxnumber = new ThreeVariablesMaximumNumber(); //Class and it's Method

            int maxintnumber = maxnumber.checkMaximumNum(10, 20, 35);  // Passing Input's
            Console.WriteLine(maxintnumber);

            float maxfloatnumber = maxnumber.checkMaximumNum(1.2f, 2.3f, 3.5f);  // Passing Input's
            Console.WriteLine(maxfloatnumber);

            string maxstring = maxnumber.checkMaximumNum("Apple","Banana","Strawberry");  // Passing Input's
            Console.WriteLine(maxstring);
        }

    }
}