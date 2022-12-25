using Struct__Const_Enum.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Const_Enum.Services
{
    internal class CalculateService : ICalculateService
    {
        public void SumNumbers(int num1,  int num2)
        {
            int sum = num1 * num2;
            Console.WriteLine(sum);
        }
        public int GetSumNumbersFromArray(int[] numbers)
        {
            int sum = 1;
            foreach(var item in numbers)
            {
                sum *= item;
            }
          
            return sum;




        }

        
    }
}
