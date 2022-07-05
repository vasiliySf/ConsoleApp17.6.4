using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17._6._4
{
    public class Calculator
    {
        public IAccount Account { get; set; }

        public Calculator(IAccount account)
        {
            Account = account;
        }
        public void CalculateInterest()
        {
            Account.CalculateInterest();
            
        }
    }
}
