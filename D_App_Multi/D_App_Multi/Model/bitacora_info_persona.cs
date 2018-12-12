using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class bitacora_info_persona:PropertyChangedService
    {
        private double peso;

        public double Peso
        {
            get { return peso; }
            set { peso = value;
                OnPropertyChanged();
            }
        }

        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value;
                OnPropertyChanged();
            }
        }

        private double? imc;

        public double? Imc
        {
            get { return imc; }
            set { imc = value;
                OnPropertyChanged();
            }
        }


        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value;
                OnPropertyChanged();
            }
        }

    }
}
