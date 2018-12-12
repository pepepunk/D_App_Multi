using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class tipo_alimento:PropertyChangedService
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value;
                OnPropertyChanged();
            }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value;
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

    }
}
