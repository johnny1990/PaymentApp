using PaymentApplication.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApplication.Presentation.Operations
{
    public class ProcessPaymentOperations
    {
        private CreditCard card = new CreditCard();


        public void ProcessPayment()
        {
            Console.WriteLine("-------------------Welcome to Payment Demo Applicaton-----------------------------");
            Console.WriteLine("You need to introduce your Credit Card Number, Card Holder, Expiration date, Security Code  and to perform validation!");

            Console.WriteLine("Enter the Credit Number!");
            card.CreditCardNumber = Console.ReadLine();

            Console.WriteLine("Enter the Card Holder!");
            card.CardHolder = Console.ReadLine();

            Console.WriteLine("Enter Expiration date!");
            card.ExpirationDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Security code!");
            card.SecurityCode = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Amount!");
            card.Amount = Decimal.Parse(Console.ReadLine());
        }
    }
}
