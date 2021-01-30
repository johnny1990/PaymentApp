using PaymentApplication.Contracts;
using PaymentApplication.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApplication.Repositories
{
    public class ExpensivePayment : IExpensivePayment
    {
        private PaymentDBEntities _db = new PaymentDBEntities();

        public void SaveDataAsExpensivePayment(CreditCard cd)
        {
            try
            {
                _db.CreditCards.Add(cd);
                _db.SaveChanges();
                Console.WriteLine("Premium Payment has been processed successfully");

                GC.SuppressFinalize(_db);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
