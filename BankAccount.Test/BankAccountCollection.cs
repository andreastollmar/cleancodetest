using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Test
{
    [CollectionDefinition(nameof(BankAccountCollection))]
    public class BankAccountCollection :ICollectionFixture<BankAccountFixture>
    {
    }
}
