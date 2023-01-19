using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePrograms
{
    public class Swap
    {
        public void c()
        {
            int number1 = 10, number2 = 20, temp = 0;
            Console.WriteLine($"Before Swapping number1= {number1}, number2 = {number2}");
            temp = number1; //temp=10
            number1 = number2; //number1=20      
            number2 = temp; //number2=10    
            Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
            Console.ReadLine();
        }
    }
}
