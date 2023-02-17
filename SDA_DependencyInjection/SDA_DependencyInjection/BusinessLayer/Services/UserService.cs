using Microsoft.AspNetCore.Identity;
using SDA_DependencyInjection.BusinessLayer.Interfaces;
using SDA_DependencyInjection.Classes;
using SDA_DependencyInjection.DataLayer.Entities;
using SDA_DependencyInjection.DataLayer.Interfaces;

namespace SDA_DependencyInjection.BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository ;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Get user By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private User GetUserByID(int id)
        {
            var user = _userRepository.GetUserByID(id);
            return user;
        }

        /// <summary>
        /// Merr fitimet per user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public double MerrFitimetPerUser(int id)
        {
            var user = _userRepository.GetUserByID(id);
            var calculator = new PagaVjetoreNeto
                (
                    user.PagaMujoreBruto,
                    user.Taksa,
                    user.ShpenzimeMujore
                );
            var fitimet = calculator.LlogaritFitimetPerVit();
            return fitimet;

        }
    }
}
