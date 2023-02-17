using WebAppDI.DataLayer.Entities;

namespace WebAppDI.DataLayer.StaticData
{
    public static class StaticData
    {
        public static List<Perdorues> _perdoruesit = new List<Perdorues>()
        {
            new Perdorues()
            {
                Emri = "Albi",
                Mbiemri = "Goxhaj",
                Adress = "Str Kont Leopold",
                Ditelindje = new DateTime(1997,08,14),
                Email = "email@test.com",
                Id = 1,
                Pershkrim = "System User" ,
                EmriPlote = "T"
            } ,
            new Perdorues()
            {
                Emri = "Maria",
                Mbiemri = "Tron",
                Adress = "Str Kont Leopold",
                Ditelindje = new DateTime(2000,08,14),
                Email = "email2@test.com",
                Id = 1,
                Pershkrim = "System User",
                EmriPlote = "T"
            }
        };
    }
}
