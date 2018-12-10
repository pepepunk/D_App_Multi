using D_App_Multi.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D_App_Multi.Service
{
    public interface IUserProvider
    {
        Task<Usuario> GetUserByUserPassword(string user, string password);
    }
}
