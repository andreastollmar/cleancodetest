using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Test
{
    public class BankAccountFixture
    {
        public Account RegularAccount { get; set; } = new Account();


        public BankAccountFixture()
        {
            RegularAccount.BankAccountNumber = 123456789;
            RegularAccount.Balance = 500;
            RegularAccount.Name  = "Test";
        }

    }
}
