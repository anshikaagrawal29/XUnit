using System.Security.Cryptography.X509Certificates;

namespace UnitTestProjectXunit1
{
    public class UnitTest1
    {

        public static class Calculator
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Check(int a, int b)
            {
                if (a == 0 || b == 0)
                {
                    throw new Exception("Incorrect value passed");
                }
                else
                {
                    return a + b;
                }
            }
        }

        [Fact]
        public void PassedCase()
        {
            Assert.Equal(4, Calculator.Add(2, 2));
        }

        [Fact]
        public void FailedCase()
        {
            Assert.Equal(5, Calculator.Add(2, 2));
        }


        [Fact]
        public void CheckPassedCase()
        {
            int a = 1, b = 1;

            try
            {
                Assert.Equal(2,Calculator.Check(a, b));

            }
            catch (Exception ex)
            {
                string actual = ex.Message;
                string expected = "Incorrect value passed";
                throw new Exception(expected);
            }

        }

        [Fact]
        public void CheckFailedCase()
        {
            int a = 0, b = 0;

            try
            {
                Calculator.Check(a, b);

            }
            catch (Exception ex)
            {
                string actual = ex.Message;
                string expected = "Incorrect value passed";
                throw new Exception(expected);
            }
            
        }
    }
}