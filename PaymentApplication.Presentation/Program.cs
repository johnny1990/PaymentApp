using PaymentApplication.Presentation.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApplication.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessPaymentOperations pp = new ProcessPaymentOperations();
            pp.ProcessPayment();
            Console.WriteLine("--------------------------------------------------");
            Console.ReadLine();
        }
    }
}
