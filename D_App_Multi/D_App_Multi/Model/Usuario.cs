using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class Usuario
    {
        private string nombre_usuario;

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
