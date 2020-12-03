using System;
using Xunit;
using Client;

namespace TestArea
{
    public class InputTest
    {
        [Fact]
        public void ValidationTest1()
        {
            string input = "12";
            int expected = 12;

            TestValidationInput test = new TestValidationInput();
            int result = test.ValidationTestProductnumber(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ValidationTest2()
        {
            string input = "1442";
            int expected = 4;
            TestValidationInput test = new TestValidationInput();
            int result = test.ValidationAmountLength(input);
           Assert.Equal(expected, result);
        }
        [Fact]
        public void ValidationTest3()
        {
            string input = "1/2";
            string expected = input;
            TestValidationInput test = new TestValidationInput();
            string result = test.ValidationColli(input);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ValidationTest4()
        {
            TestValidationInput test = new Client.TestValidationInput();
            double numberGiven = test.ValidationTestVolumenumber();
            double high = 500.0;
            double low = 0.0;
            Assert.True(numberGiven <= high);
            Assert.True(numberGiven >= low);
        }

    }

}
