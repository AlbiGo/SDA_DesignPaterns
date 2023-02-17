using SDA_DependencyInjection.DataLayer.Entities;

namespace SDA_DependencyInjection.DataLayer.StaticData
{
    public static class StaticData
    {
        public static List<User> _users = new List<User>()
        {
            new User()
            {
                Emri = "Albi ",
                Mbiemri = "Goxhaj",
                ID = 1,
                PagaMujoreBruto = 5000,
                ShpenzimeMujore = 500,
                Taksa = 0.35
            },
             new User()
            {
                Emri = "Klevi ",
                Mbiemri = "Dervishi",
                ID = 2,
                PagaMujoreBruto = 7000,
                ShpenzimeMujore = 600,
                Taksa = 0.40
            }
        };

    }
}
