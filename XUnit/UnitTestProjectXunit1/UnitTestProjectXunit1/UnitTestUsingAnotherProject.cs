using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentCalculation;


namespace UnitTestProjectXunit1
{
    public class UnitTestUsingAnotherProject
    {
        Payments p = new Payments();

        [Fact]
        public void PassedTestSum()
        {
            Assert.Equal(2, p.sum(1, 1));
        }

        [Fact]
        public void PassedCheckEvenAndOdd()
        {
            Assert.True(p.CheckEvenOdd(2));
        }

        [Fact]
        public void FailedCheckEvenAndOdd()
        {
            Assert.True(p.CheckEvenOdd(3));
        }

        [Fact]
        public void PassedCheckIdExists()
        {
            Guid id = p.createPaymentTransaction();
            Guid retreivedId = p.GetTransaction(id);
            Assert.Equal(id, retreivedId);
        }

        // Does not contains check
        [Fact]
        public void FailedCheckIdExists()
        {
            Guid id = new Guid();
            try
            {
                Guid retreivedId = p.GetTransaction(id);
                Assert.Equal(id, retreivedId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        // empty check
        [Fact]
        public void EmptyPaymentIdCheck()
        {
            Guid id = Guid.Empty;
            
            try
            {
                Guid retreivedId = p.GetTransaction(id);
            }
            catch(Exception e)
            {
                if (e.Message == "Payment Id empty.")
                { 
                    throw new Exception("Payment Id empty inside catch");
                }
            }
            
        }

    }
}
