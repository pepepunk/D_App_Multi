using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class Usuario:PropertyChangedService
    {
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy = false; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChanged();
            }
        }

        private string nombre_usuario;

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value;
                OnPropertyChanged();
            }
        }

        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value;
                OnPropertyChanged();
            }
        }

        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value;
                OnPropertyChanged();
            }
        }

        private int persona_id;

        public int Persona_id
        {
            get { return persona_id; }
            set { persona_id = value; }
        }

    }
}
