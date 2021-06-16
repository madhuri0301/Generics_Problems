using NUnit.Framework;
using Generics_Problems;
namespace TestMaximumNumber
{
    public class Tests
    {

        ThreeVariablesMaximumNumber maximum = new ThreeVariablesMaximumNumber();
        //Test Cases For Integer Number
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
        //Test Cases For Float Value
        [Test]
        public void Given_Max_Float_Number_at_1st_Position_return_the_Same_Number()
        {
            float maximumResult = maximum.checkMaximumNum(1.2f, 2.3f, 3.5f);
            AssertionException.Equals(1.2f, maximumResult);
        }
        [Test]
        public void Given_Max_Float_Number_at_2nd_Position_return_the_Same_Number()
        {
            float maximumResult = maximum.checkMaximumNum(1.2f, 2.3f, 3.5f);
            AssertionException.Equals(2.3f, maximumResult);
        }
        [Test]
        public void Given_Max_Float_Number_at_3rd_Position_return_the_Same_Number()
        {
            float maximumResult = maximum.checkMaximumNum(1.2f, 2.3f, 3.5f);
            AssertionException.Equals(3.5f, maximumResult);
        }
        [Test]
        public void Given_Max_String_Number_at_1st_Position_return_the_Same_Number()
        {
            string maximumResult = maximum.checkMaximumNum("Apple", "Banana", "Strawberry");
            AssertionException.Equals("Apple", maximumResult);
        }
        [Test]
        public void Given_Max_String_Number_at_2nd_Position_return_the_Same_Number()
        {
            string maximumResult = maximum.checkMaximumNum("Apple", "Banana", "Strawberry");
            AssertionException.Equals("Banana", maximumResult);
        }
        [Test]
        public void Given_Max_String_Number_at_3rd_Position_return_the_Same_Number()
        {
            string maximumResult = maximum.checkMaximumNum("Apple", "Banana", "Strawberry");
            AssertionException.Equals("Strawberry", maximumResult);
        }
        [Test]
        public void GivenIntegerArray_ShouldReturnLargestInteger()
        {
            int[] values = { 10, 20, 35, 26, 16 };
            GenericMaximum<int> maximumNumber = new GenericMaximum<int>(values);

            int max = maximumNumber.MaxValue();

            Assert.AreEqual(35, max);
        }
        [Test]
        public void GivenFloatArray_ShouldReturnLargestFloat()
        {
            float[] values = { 1.2f, 2.3f, 3.5f, 2.1f, 1.6f };
            GenericMaximum<float> maximumNumber = new GenericMaximum<float>(values);

            float max = maximumNumber.MaxValue();

            Assert.AreEqual(3.5f, max);
        }
        [Test]
        public void GivenStringArray_ShouldReturnLargestString()
        {
            string[] values = { "Apple", "Banana", "Strawberry", "WaterMelon", "Mango" };
            GenericMaximum<string> maximumNumber = new GenericMaximum<string>(values);

            string max = maximumNumber.MaxValue();

            Assert.AreEqual("WaterMelon", max);
        }

    }
}