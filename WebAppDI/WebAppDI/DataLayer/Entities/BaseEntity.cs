namespace WebAppDI.DataLayer.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Emri { get; set; }
        public string Pershkrim { get; set; }
        public DateTime DataKrijimit { get; set; }
        public DateTime DataPerditesimit { get; set; }
        public DateTime DataFshirjes { get; set; }
        public decimal KohaNeSist { get; set; }

        public BaseEntity()
        {
            DataKrijimit= DateTime.Now;
            Guid = Guid.NewGuid();
        }
    }
}
