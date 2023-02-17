using WebAppDI.BusinessLayer.Interfaces;
using WebAppDI.DataLayer.Entities;
using WebAppDI.DataLayer.Interfaces;
using WebAppDI.DataLayer.Repositories;

namespace WebAppDI.BusinessLayer.Services
{
    public class PerdoruesService : IPerdoruesService
    {
        private readonly IPerdoruesRepo _perdoruesRepo;
        public PerdoruesService(IPerdoruesRepo perdoruesRepo)
        {
            _perdoruesRepo = perdoruesRepo;
        }
        public List<Perdorues> MerrPerddoruesit()
        {
            return _perdoruesRepo.MerrTeGjithePerdoruesit();
        }
    }
}
