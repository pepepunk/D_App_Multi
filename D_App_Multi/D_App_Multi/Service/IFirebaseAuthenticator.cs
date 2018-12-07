using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D_App_Multi.Service
{
    public interface IFirebaseAuthenticator
    {
        Task<string> LoginWithEmailPassword(string email, string password);
    }
}
