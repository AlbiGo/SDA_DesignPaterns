


using WebAppDI.DataLayer.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var p = new Perdorues()
        { 
            Emri = "test",
            Adress = "test",
            Email = "test@",
            Mbiemri = "test3",
            Ditelindje = new DateTime(1200, 08, 14)
        };
        p.VendosEmrinEPlote();
        var valid = p.ValidoMoshen();
        Console.WriteLine(valid);
        var validEmail = p.ValidoEmail();
    }
}