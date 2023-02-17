using SDA_DependencyInjection.DataLayer.Entities;

namespace SDA_DependencyInjection.DataLayer.Interfaces
{
    /// <summary>
    /// User Repository Interface
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Get User By id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserByID(int id);
    }
}
