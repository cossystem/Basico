using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ13
{
    class CCursos
    {
        private int id;
        private string Descripcion;

        public int Id { get => id; set => id = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }

        public CCursos(int pId,string pDescripcion)
        {
            Id = pId;
            Descripcion = pDescripcion;
        }

    }
}
