using System.Collections.Generic;
using System.Threading.Tasks;
using HandIn4.Models;

namespace HandIn4.Database.Context
{
    public interface DAOUser
    {
        Task<IList<User>> getUsers();
    }
}