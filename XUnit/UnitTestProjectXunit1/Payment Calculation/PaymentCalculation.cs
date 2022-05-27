using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace PaymentCalculation
{
    public class Payments
    {
        HashSet<Guid> paymentIds = new HashSet<Guid>();

        public int sum(int a, int b)
        {
            return a + b;
        }


        public bool CheckEvenOdd(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }

        //Create payment Id
        public Guid createPaymentTransaction()
        {
            Guid paymentId = new Guid();
            paymentIds.Add(paymentId);

            return paymentId;
            
        }

        //Get payment Id
        public Guid GetTransaction(Guid paymentId)
        {
            if (paymentId != Guid.Empty && !paymentIds.Contains(paymentId))
            {
                throw new Exception("Payment Id not found");
            }
            else if (paymentId == Guid.Empty)
            {
                throw new Exception("Payment Id empty.");  
            }
            else
                return paymentId;
        }

        public static void Main()
        {
            Console.WriteLine("Payments!!");

            Payments p = new Payments();
            int result = p.sum(1, 2);

            Console.WriteLine(result);

        }
    }


}


