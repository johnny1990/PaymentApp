using PaymentApplication.Contracts;
using PaymentApplication.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApplication.Repositories
{
    public class CheapPayment : ICheapPayment
    {
        private PaymentDBEntities _db = new PaymentDBEntities();

        public void SaveDataAsCheapPaymentService(CreditCard cd)
        {
            try
            {
                _db.CreditCards.Add(cd);
                _db.SaveChanges();
                Console.WriteLine("Cheap Payment has been processed successfully");

                GC.SuppressFinalize(_db);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
