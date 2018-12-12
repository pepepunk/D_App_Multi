using System;
using System.Collections.Generic;
using System.Text;

namespace D_App_Multi.Model
{
    public class alimento:PropertyChangedService
    {
        private string _alimento;

        public string Alimento
        {
            get { return _alimento; }
            set { _alimento = value;
                OnPropertyChanged();
            }
        }

        private string cantidad_equivalente_una_porcion;

        public string Cantidad_equivalente_una_porcion
        {
            get { return cantidad_equivalente_una_porcion; }
            set { cantidad_equivalente_una_porcion = value;
                OnPropertyChanged();
            }
        }

    }
}
