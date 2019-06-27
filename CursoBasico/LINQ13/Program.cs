using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelada", "fresa con crema", "pay de pera y manzana" };
            string[] palabras = { "hola", "piedra", "pato", "pastel", "carros", "auto" };

            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante(100,"Ana"),
                new CEstudiante(150,"Mario"),
                new CEstudiante(180,"Susana")
            };

            List<CCursos> cursos = new List<CCursos>
            {
                new CCursos(100,"Programacion"),
                new CCursos(150,"Orientados objetos"),
                new CCursos(150,"Programacion"),
                new CCursos(180,"Programacion"),
                new CCursos(100,"UML"),
                new CCursos(100,"Orientado objetos"),
                new CCursos(180,"UML")
            };

            var listado = from e in estudiantes
                          join c in cursos
                          on e.Id equals c.Id
                          select e.Nombre + " esta en el curso " + c.Descripcion1;

            foreach (var lst in listado)
            {
                Console.WriteLine(lst);
            }

            //los resultados se obtienen en forma jerarquica
            //la sintaxis es la misma pero utilizamos into

            Console.WriteLine("-----Con Jerarquias----");

            var lista2 = from e in estudiantes
                         join c in cursos
                         on e.Id equals c.Id
                         into tmpListado
                         select new { e.Nombre, tmpListado };

            foreach (var lst in lista2)
            {
                Console.WriteLine(lst.Nombre);
                foreach (var lst2 in lst.tmpListado)
                {
                    Console.WriteLine(lst2.Descripcion1);
                }

            }

            //Zip 
            //Regresa una secuencia que aplica un funcion a cada par

            Console.WriteLine("-----zip-----\r\n");
            #region zip
            string[] helados = { "Chocolate", "vainilla", "fresa", "limon" };

            IEnumerable<string> r12 = postres.zip()


            #endregion
        }
    }
}
