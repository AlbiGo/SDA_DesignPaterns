// See https://aka.ms/new-console-template for more information
using SDADI.BusinnesLayer.Services;
using SDADI.DataLayer.TeDhena;

Console.WriteLine("Hello, World!");
var userService = new UserService(new UserData());
var perdoruesit = userService.MerrPerdoruesit();
foreach (var u in perdoruesit)
{
    Console.WriteLine(u.Name);
}
userService.ShtoPerdorues(new SDADI.DataLayer.Entities.User() { Id = 4,Name = "ädam f" });
var perdoruesit2 = userService.MerrPerdoruesit();
Console.WriteLine(Environment.NewLine);
foreach (var u in perdoruesit)
{
    Console.WriteLine(u.Name);
}

