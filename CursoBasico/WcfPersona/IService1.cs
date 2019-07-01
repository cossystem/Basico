using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfPersona
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        // TODO: agregue aquí sus operaciones de servicio
        [OperationContract]
        Persona getPersona(int id, string nombre, string apellidos, int edad);
        
    }
}
