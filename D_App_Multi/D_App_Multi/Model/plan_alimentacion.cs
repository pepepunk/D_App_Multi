using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class plan_alimentacion:PropertyChangedService
    {
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value;
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
