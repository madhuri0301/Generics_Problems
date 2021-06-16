using System;

namespace Generics_Problems
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = { 10,20,35,26,16 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            Console.WriteLine(generic.MaxValue());
            float[] floatArray = { 1.2f, 2.3f, 3.5f,2.1f,1.6f };
            GenericMaximum<float> genericFloat = new GenericMaximum<float>(floatArray);
            Console.WriteLine(genericFloat.MaxValue());
            string[] stringArray = { "Apple", "Banana", "Strawberry","WaterMelon","Mango" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            Console.WriteLine(genericString.MaxValue());
        }
    }
}