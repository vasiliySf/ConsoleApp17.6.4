using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17._6._4
{
    public class SalaryAccount: IAccount
    {
        // баланс учетной записи
         public double Balance { get; set; }
        // процентная ставка
        public double Interest { get; set; }
        public SalaryAccount(double balance)
        {
            this.Balance = balance;            
        }
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
           Console.WriteLine("Зарплатный счет, процентная ставка : " + Interest);
        }
    }
}
