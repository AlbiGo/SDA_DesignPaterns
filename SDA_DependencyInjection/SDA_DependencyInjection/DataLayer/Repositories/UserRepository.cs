using SDA_DependencyInjection.DataLayer.Entities;
using SDA_DependencyInjection.DataLayer.Interfaces;

namespace SDA_DependencyInjection.DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        //Get a user by ID
        private List<User> _users;

        //Load users
        public UserRepository() 
        {
            _users = StaticData.StaticData._users;
        }

        /// <summary>
        /// Find User by given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserByID(int id)
        {
            try
            {
                var user = _users.Where(p => p.ID == id)
                    .First();

                if(user == null)
                {
                    throw new Exception("User not found");
                }

                return user;
            }
            catch(Exception ex)
            {
                throw new Exception("Error getting User");
            }
        }

    }
}
