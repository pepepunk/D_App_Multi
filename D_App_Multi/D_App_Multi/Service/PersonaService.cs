using D_App_Multi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace D_App_Multi.Service
{
    public class PersonaService
    {
        public ObservableCollection<Persona> personas { get; set; }

        public PersonaService()
        {
            if (personas == null)
            {
                personas = new ObservableCollection<Persona>();
            }
        }

        public ObservableCollection<Persona> Consultar()
        {
            return personas;
        }

        public void Guardar(Persona modelo)
        {
            personas.Add(modelo);
        }

        public void Modificar(Persona modelo)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Id == modelo.Id)
                {
                    personas[i] = modelo;
                }
            }
        }

        public void Eliminar(int id)
        {
            Persona modelo = personas.FirstOrDefault(x => x.Id == id);
            personas.Remove(modelo);
        }
    }
}
