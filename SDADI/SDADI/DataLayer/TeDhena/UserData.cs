using SDADI.DataLayer.Entities;
using SDADI.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDADI.DataLayer.TeDhena
{
    public static class StaticData
    {
        public static List<User> _users = new List<User>()
        {
            new User()
                {
                    Gjinia = "Femer",
                    Id = 1,
                    Name = "Ada T",
                    Description = "Perdorues"

                },
                new User()
                {
                    Gjinia = "Femer",
                    Id = 2,
                    Name = "John T",
                    Description = "Perdorues"

                }
        };

    }

    public class UserData : IUserData
    {
        public List <User> MerrPerdoruesít()
        {
            return StaticData._users;
        }

        public void ShtoUser(User user)
        {
            StaticData._users.Add(user);
        }

        public void FshiUser(int id)
        {
            var user = StaticData._users.Where(p => p.Id == id).First();
            if(user != null)
            {
                StaticData._users.Remove(user);
            }
        }
    }
}
