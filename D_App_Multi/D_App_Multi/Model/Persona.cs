using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class Persona : PropertyChangedService
    {
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy = false; }
            set { isBusy = value;
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

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private string primer_apellido;

        public string Primer_apellido
        {
            get { return primer_apellido; }
            set { primer_apellido = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
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

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value;
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

        private string nombreCompleto;
        public string NombreCompleto
        {
            get { return $"{Nombre} {Primer_apellido}"; }
            set
            {
                nombreCompleto = value;
                OnPropertyChanged();
            }
        }

        private int usuario_id;

        public int Usuario_id
        {
            get { return usuario_id; }
            set { usuario_id = value; }
        }

    }
}
