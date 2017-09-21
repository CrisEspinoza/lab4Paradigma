using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string equipoUs(string nombre);

        [OperationContract]
        int puntajeUs(string nombre);

        [OperationContract]
        string apodoUs(string nombre);

        [OperationContract] //Simpre poer eo antes de un metodo
        bool usuario(string nombre, string contrasena);

        [OperationContract]
        bool registrarUsuario(string nombre, string contrasena, string apodo, string equipoPreferido);

        [OperationContract]
        bool actualizarPuntaje(int puntaje , string usuario);

    }
    
}
