namespace SDA_DependencyInjection.Classes
{
    public class PagaVjetoreNeto
    {
        private readonly double _taks ;
        private readonly double _pagaMujoreBruto; //Euro
        private readonly PagaVjetore _pagaVjetore;
        private readonly double _shpenzimeMujore;
        public PagaVjetoreNeto(double pagaVjetoreBruto, double takse , double shpenzimeMUjore)
        {
            _pagaVjetore = new PagaVjetore();
            _pagaMujoreBruto = pagaVjetoreBruto;
            _taks = takse;
            _shpenzimeMujore = shpenzimeMUjore;
        }

        private double LlogaritShpenzimeVjetore()
        {
            return _shpenzimeMujore * 12;
        }

        public double LlogaritFitimetPerVit()
        {
            var pagaVjetoreNeto = LLogaritPagenVjetoreNeto();
            var shpenzimet = LlogaritShpenzimeVjetore();
            return (pagaVjetoreNeto - shpenzimet);
        }
        public double LLogaritPagenVjetoreNeto()
        {
            var pagaVjetoreBruto = _pagaVjetore.LogaritPagenVjetore(_pagaMujoreBruto);
            var pagaVjetoreNeto = pagaVjetoreBruto * _taks;
            return pagaVjetoreNeto;
        }
    }
}
