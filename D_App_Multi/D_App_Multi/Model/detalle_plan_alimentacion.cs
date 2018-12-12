using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class detalle_plan_alimentacion:PropertyChangedService
    {
        private double numero_procion;

        public double Numero_porcion
        {
            get { return numero_procion; }
            set { numero_procion = value;
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

        private string tipo_alimento_key;

        public string Tipo_alimento_key
        {
            get { return tipo_alimento_key; }
            set { tipo_alimento_key = value;
                OnPropertyChanged();
            }
        }

    }
}
