



using Struct__Const_Enum.Constants;
using Struct__Const_Enum.Enum;
using Struct__Const_Enum.Services;
using Struct__Const_Enum.Services.Interface;

ICalculateService service = new CalculateService();
int result = service.GetSumNumbersFromArray(new int[] { 2, 4, 6, });
Console.WriteLine(result);



Account login = new Account("Aydin ", "Alizada", 25, "baku");
static Account GetAccount(Account login)
{
    return login;

}
string email = "azechanpiongmail.com";


if (email != "azechanpiongmail.com")
{
    Console.WriteLine(Errors.Login);
}