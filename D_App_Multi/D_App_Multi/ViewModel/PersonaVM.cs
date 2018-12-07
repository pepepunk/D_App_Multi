using D_App_Multi.Model;
using D_App_Multi.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace D_App_Multi.ViewModel
{
    public class PersonaVM:Persona
    {
        public ObservableCollection<Persona> Personas { get; set; }
        PersonaService servicio = new PersonaService();
        Persona modelo;
        public PersonaVM()
        {
            GuardarCommand = new Command(async () => await Guardar(), () => !IsBusy);
            ModificarCommand = new Command(async () => await Modificar(), () => !IsBusy);
            EliminarCommand = new Command(async () => await Eliminar(), () => !IsBusy);
            LimpiarCommand = new Command(Limpiar, () => !IsBusy);
            Personas = servicio.Consultar();
        }

        public Command GuardarCommand { get; set; }
        public Command ModificarCommand { get; set; }

        public Command EliminarCommand { get; set; }

        public Command LimpiarCommand { get; set; }

        private async Task Guardar()
        {
            IsBusy = true;
            Guid IdPersona = Guid.NewGuid();
            modelo = new Persona()
            {
                Nombre = Nombre,
                Primer_apellido = Primer_apellido,
                Edad = Edad,
                Id = Id
            };
            servicio.Guardar(modelo);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private async Task Modificar()
        {
            IsBusy = true;

            modelo = new Persona()
            {
                Nombre = Nombre,
                Primer_apellido = Primer_apellido,
                Edad = Edad,
                Id = Id
            };
            servicio.Modificar(modelo);
            await Task.Delay(2000);
            IsBusy = false;
        }
        private async Task Eliminar()
        {
            IsBusy = true;
            servicio.Eliminar(Id);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private void Limpiar()
        {
            Nombre = "";
            Primer_apellido = "";
            Id = 0;
            Edad = 0;
        }
    }
}
