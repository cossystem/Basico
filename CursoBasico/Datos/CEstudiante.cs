using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    /// <summary>
    /// Crea una instancia de la clase Estudiante
    /// </summary>
    /// <param name="Id">Id Del Estudiante</param>
    /// <param name="Nombre">Nombre del Estudiante</param>
    class CEstudiante
    {
        //Se Agregan los Atributos
        private int id;
        private string nombre;

        //Se Agregan Las Propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //Se Crea el Constructor Vacio
        public CEstudiante()
        {
            id = 0;
            nombre = "";            
        }

        //Se Crea el Constructor lleno
        public CEstudiante(int _id,string _nombre)
        {
            Id = _id;
            Nombre = _nombre;
        }

        public String NombreCompleto()
        {
            return string.Format("El Nombre Nombre completo es Clave {0}, Nombre {0} ", Id, Nombre);

        }
    }
}
