using System;

namespace ConsoleApp17._6._4;

class programm
{
    public static void Main(String[] args)
    {
        
        Calculator calculator = new Calculator(new BaseAccount(500.0));        
        calculator.CalculateInterest();
      
        Console.WriteLine();
                
        Calculator calculator1 = new Calculator(new SalaryAccount(1500.0));
        calculator1.CalculateInterest();
               
    } 

}


