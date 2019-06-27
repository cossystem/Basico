using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ13
{
    class CEstudiante
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public CEstudiante(int pId,string pNombre)
        {
            Id = pId;
            Nombre = pNombre;
        }
    }
}
