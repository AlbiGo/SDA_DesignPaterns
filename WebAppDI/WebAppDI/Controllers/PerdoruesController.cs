using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppDI.BusinessLayer.Interfaces;
using WebAppDI.BusinessLayer.Services;
using WebAppDI.DataLayer.Entities;

namespace WebAppDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerdoruesController : ControllerBase
    {
        private readonly IPerdoruesService _perdoruesService;

        //Controller Constructor
        public PerdoruesController(IPerdoruesService perdoruesService)
        {
            //Service Initialisation
            _perdoruesService = perdoruesService;
        }

        /// <summary>
        /// Merr te gjithe perdoruesit
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "merrperddoruesit")]
        public List<Perdorues> MerrPerddoruesit()
        {
            //var ps = new PerdoruesService(new DataLayer.Repositories.PerdoruesRepo());
            return _perdoruesService.MerrPerddoruesit();
        }
    }
}
