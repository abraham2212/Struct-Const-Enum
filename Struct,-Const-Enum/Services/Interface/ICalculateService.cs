using Struct__Const_Enum.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Const_Enum.Services.Interface
{
    internal interface ICalculateService
    {
        void SumNumbers(int num1,int num2);
        int GetSumNumbersFromArray(int[] numbers); 
    }
}
int roleId = 2;

switch (roleId)
{
    case (int)Roles.SuperAdmin:
        Console.WriteLine("super admindir");
        break;
    case(int)Roles.Admin:
        Console.WriteLine("admindir");
        break;
    case (int)Roles.Member:
        Console.WriteLine("memberdir ");
        break;
    default:
        Console.WriteLine("roles tapilmadi");
        break;





}
    
    
  
    
