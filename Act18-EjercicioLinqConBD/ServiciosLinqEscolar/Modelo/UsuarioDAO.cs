using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosLinqEscolar.Modelo
{
    public static class UsuarioDAO
    {
        public static List<usuario> obtenerUuarios()
        {
            DataClassesEscolarUVDataContext conexionBD = getConection();

            IQueryable<usuario> usuariosBD = from usuarioQuery 
                                             in conexionBD.usuario 
                                             select usuarioQuery;

            return usuariosBD.ToList();
        }

        public static usuario iniciarSesion(string username,string password)
        {
            DataClassesEscolarUVDataContext conexionBD = getConection();

            var usuario = (from userLogin in conexionBD.usuario
                           where userLogin.username == username &&
                           userLogin.password == password
                           select userLogin).FirstOrDefault();

            return usuario;
        }


        public static Boolean GuardarUsuario(usuario usuarioNuevo) 
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConection();

                var usuario = new usuario()
                {
                    nombre = usuarioNuevo.nombre,
                    apellidoPaterno = usuarioNuevo.apellidoPaterno,
                    apellidoMaterno = usuarioNuevo.apellidoMaterno,
                    username = usuarioNuevo.username,
                    password = usuarioNuevo.password

                    
                };
                conexionBD.usuario.InsertOnSubmit(usuario);
                conexionBD.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static Boolean EditarUsuario(usuario UsuarioEdicion)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConection();
                var usuario = (from usuarioEdicion in conexionBD.usuario
                              where usuarioEdicion.idUsuario== UsuarioEdicion.idUsuario
                              select usuarioEdicion).FirstOrDefault();
                if(usuario != null )
                {
                    usuario.nombre = UsuarioEdicion.nombre;
                    usuario.apellidoPaterno = UsuarioEdicion.apellidoPaterno;
                    usuario.apellidoMaterno = UsuarioEdicion.apellidoMaterno;
                    usuario.password = UsuarioEdicion.password;
                    conexionBD.SubmitChanges() ;
                    return true;
                }
                else { return false; }
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
        public static Boolean eliminarUsuario(int idUsuario)
        {
            try
            {
                DataClassesEscolarUVDataContext conexionBD = getConection();
                usuario usuarioEliminar = (from usuario in conexionBD.usuario
                                           where usuario.idUsuario == idUsuario
                                           select usuario).FirstOrDefault();
                if (usuarioEliminar != null)
                {
                    conexionBD.usuario.DeleteOnSubmit(usuarioEliminar);
                    conexionBD.SubmitChanges();
                    return true;
                }else { return false; }

            }catch(Exception ex) { return false; }
            
        }

        public static DataClassesEscolarUVDataContext getConection()
        {
            return new DataClassesEscolarUVDataContext(global::System.Configuration.
                ConfigurationManager.ConnectionStrings["escolarUVConnectionString"].
                ConnectionString);

        }
    }
}