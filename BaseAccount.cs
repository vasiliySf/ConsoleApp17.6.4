using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17._6._4
{
    public class BaseAccount: IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public BaseAccount(double balance)
        {
            this.Balance = balance;            
        }
        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка 
            // расчет правда странный, но это не ко мне )
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine("Обычный счет, процентная ставка : "+ Interest);
        }
    }
}
