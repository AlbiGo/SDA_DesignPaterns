// See https://aka.ms/new-console-template for more information
using SDA_DependencyInjection.DataLayer.Entities;
using System.Text;

Console.WriteLine("Hello, World!");
var user = new UserEconomics()
{ 
    ID = 1,
    PagaMujoreBruto = 5000,
    ShpenzimeMujore = 500,
    Taksa = 0.35
};

var user2 = new UserEconomics()
{
    ID = 2,
    PagaMujoreBruto = 6000,
    ShpenzimeMujore = 700,
    Taksa = 0.35
};
List<UserEconomics> users = new List<UserEconomics>();
users.Add(user);    
users.Add(user2);
//user.LlogaritEkonomiks();
//user2.LlogaritEkonomiks();
var cmimiShtepise = 70000;
//Printo economics per cdo user
foreach(var _user in users)
{
    _user.LlogaritEkonomiks();
    Console.WriteLine("**********************************");
    Console.WriteLine(Environment.NewLine);
    var vitet = _user.LlogaritVitetPerBanese(cmimiShtepise);
    Console.WriteLine("Per te blere nje banese duhen " + vitet + " vite.");
}