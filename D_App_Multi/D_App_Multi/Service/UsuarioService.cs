using D_App_Multi.Model;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace D_App_Multi.Service
{
    public class UsuarioService
    {

        FirebaseConfiguration config = new FirebaseConfiguration();


        public Usuario GetUserByUserPasswordAsync(string user, string password)
        {
            List<Usuario> result = config.GetUsers<Usuario>("usuario");
            Usuario currentUser = null;
            foreach (var usuario in result)
            {
                if (usuario.Nombre_usuario == user && usuario.Contrasena == password)
                {
                    currentUser = usuario;
                }
            }
            return currentUser;
        }
    }
}
