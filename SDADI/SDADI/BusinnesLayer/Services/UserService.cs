using SDADI.DataLayer.Entities;
using SDADI.DataLayer.Interfaces;
using SDADI.DataLayer.TeDhena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDADI.BusinnesLayer.Services
{
    public class UserService
    {
        private  IUserData _userData;
        public UserService(IUserData userData)
        {
            _userData = userData;
        }

        public List<User> MerrPerdoruesit()
        {
            var perdoruesit = _userData.MerrPerdoruesít();
            return perdoruesit;
        }

        public void ShtoPerdorues(User user)
        {
            _userData.ShtoUser(user);
        }
    }
}
