using PaymentApplication.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentApplication.Contracts
{
    public interface IPremiumPayment
    {
        void SaveDataAsPremiumPayment(CreditCard cd);
    }
}
