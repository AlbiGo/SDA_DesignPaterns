using WebAppDI.DataLayer.Entities;
using WebAppDI.DataLayer.Interfaces;

namespace WebAppDI.DataLayer.Repositories
{
    public class PerdoruesRepo : IPerdoruesRepo
    {
        public List<Perdorues> MerrTeGjithePerdoruesit()
        {
            try
            {
                var perdoruesit = StaticData.StaticData._perdoruesit;
                return perdoruesit ;
            }
            catch(Exception ex)
            {
                throw new Exception("Error ne marrjen e perdoruesve");
            }
        }
    }
}
