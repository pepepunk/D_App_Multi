using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class usuario:PropertyChangedService
    {
        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value;
                OnPropertyChanged();
            }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
            }
        }

        private string primer_apellido;

        public string Primer_apellido
        {
            get { return primer_apellido; }
            set { primer_apellido = value;
                OnPropertyChanged();
            }
        }

        private string segundo_apellido;

        public string Segundo_apellido
        {
            get { return segundo_apellido; }
            set { segundo_apellido = value;
                OnPropertyChanged();
            }
        }

        private int? edad;

        public int? Edad
        {
            get { return edad; }
            set { edad = value;
                OnPropertyChanged();
            }
        }
    }
}
