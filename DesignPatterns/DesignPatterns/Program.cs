// See https://aka.ms/new-console-template for more information
using DesignPatterns.Classes;
using DesignPatterns.Methods;

Console.WriteLine("Hello, World!");
var punonjes = new Punonjesi()
{ 
    PagesaPerOre = 5,
    Emri = "Albi",
    Mbiemri = "Goxhaj",
    OretEPunes = 40,
    Titulli = "Punonjes"
};
var punonjes2 = new Punonjesi()
{
    PagesaPerOre = 5,
    Emri = "Albi",
    Mbiemri = "Goxhaj",
    OretEPunes = 40,
    Titulli = "Drejtor"
}; var punonjes3 = new Punonjesi()
{
    PagesaPerOre = 5,
    Emri = "Albi",
    Mbiemri = "Goxhaj",
    OretEPunes = 40,
    Titulli = "Menaxher"
};
var punonjesit = new List<LlogaritPagesenBaze>()
{
    new LlogaritPagesenDrejor(punonjes2),
    new LlogaritPagesenMenaxher(punonjes3),
    new LlogaritPagesenPunojes(punonjes)
};
var calculator = new LlogaritPagesen(punonjesit);
var pagesat = calculator.llogaritPagesen();
foreach(var paga in pagesat)
{
    Console.WriteLine(paga);
}