using SDADI.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDADI.DataLayer.Interfaces
{
    public interface IUserData
    {
        public List<User> MerrPerdoruesít();
        public void ShtoUser(User user);
        public void FshiUser(int id);

    }
}
