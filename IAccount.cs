using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17._6._4
{
    public interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }
        // процентная ставка
        public double Interest { get; set; }
        public void CalculateInterest()
        {

        }
       
    }
}
