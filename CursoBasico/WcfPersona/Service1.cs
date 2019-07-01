using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfPersona
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public Persona getPersona(int id, string nombre, string apellidos, int edad)
        {
            Persona persona = new Persona();
            persona.Id = id;
            persona.Nombre = nombre;
            persona.Apellidos = apellidos;
            persona.Edad = edad;

            return persona;

        }
    }
}
