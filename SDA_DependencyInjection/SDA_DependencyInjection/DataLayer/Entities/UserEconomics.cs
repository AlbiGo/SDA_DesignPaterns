using System.Text;
using SDA_DependencyInjection.Classes;

namespace SDA_DependencyInjection.DataLayer.Entities
{
    public class UserEconomics
    {
        private PagaVjetoreNeto calculator;

        public int ID { get; set; }
        public double PagaMujoreBruto { get; set; }
        public double ShpenzimeMujore { get; set; }
        public double Taksa { get; set; }

        //Llogarit sa vite duhen per te blere nje banese
        public double LlogaritVitetPerBanese(double cmimiShtepise)
        {
            //Na duhen fitimet
            calculator = new PagaVjetoreNeto(
                PagaMujoreBruto,
                Taksa,
                ShpenzimeMujore
                );
            var fitimet = calculator.LlogaritFitimetPerVit();
            double vitet = cmimiShtepise / fitimet;
            return vitet;
        }
        public void LlogaritEkonomiks()
        {
            calculator = new PagaVjetoreNeto(
                PagaMujoreBruto,
                Taksa,
                ShpenzimeMujore
                );
            var pagaVjetoreNeto = calculator.LLogaritPagenVjetoreNeto();
            var fitimet = calculator.LlogaritFitimetPerVit();
            var str = new StringBuilder();
            str.Append("PagaVjetore : ");
            str.Append(pagaVjetoreNeto);
            str.AppendLine();
            str.Append("Fitimet : ");
            str.Append(fitimet);
            var llogaritjet = str.ToString();
            Console.WriteLine(llogaritjet);

        }
    }
}
