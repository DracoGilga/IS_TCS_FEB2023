using ServiciosLinqEscolar.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosLinqEscolar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public bool EditarUsuario(usuario usuarioEdicion)
        {
            return UsuarioDAO.EditarUsuario(usuarioEdicion);
        }

        public bool EliminarUsuario(int idUsuario)
        {
            return UsuarioDAO.eliminarUsuario(idUsuario);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool GuardarUsuario(usuario usuarioNuevo)
        {
            return UsuarioDAO.GuardarUsuario(usuarioNuevo);
        }

        public usuario iniciarSesion(string username, string password)
        {
            return UsuarioDAO.iniciarSesion(username,password);
        }

        public List<usuario> ObtenerUsuarios()
        {
            return UsuarioDAO.obtenerUuarios();
        }
    }
}
