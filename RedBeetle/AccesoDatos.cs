using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Collections;
using Dapper;
using RedBeetle.Clases;
using MySql.Data.MySqlClient;

/****
 * 
 * This class requires add a new reference to the project which is System.Configuration
 *
 * Also this needs some new content called "Dapper", you can find what this does at https://dapper-tutorial.net/dapper, 
 * basically is just a basic mapper to allow use Query/Execute database operations.
 * 
 * This Dapper must be downloaded as another reference. Right click on References > Administrate NuGet packages, and search for Dapper, should be the first one.
 * 
 */

namespace RedBeetle
{
	//En esta clase pondremos TODAS los metodos que usen MySQL, para asi hacer mejor distribución de las clases que tendremos, y también para separar
	//el Front-End y el Back-End y también para poder usar Dapper
	public class AccesoDatos
	{
		public static Usuario DevolverUsuario(string nombreUsuario)
		{
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) { //Abrimos la conexión con la base de datos 
                using (IDbConnection conexion = dbCon.Conexion) {
                    var output = conexion.Query<Usuario>($"SELECT * FROM usuario WHERE nombre_usuario = '{ nombreUsuario }';").ToList();
                    if (output.Count != 0) {
                        Usuario usu = output[0];
                        return usu;

                    } else return null;
                    
                }
            } else return null;
        }

		public static void AgregarUsuario(Usuario usu) //EJEMPLO DE FUNCION USANDO DAPPER
		{
			var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
			if (dbCon.Conectado()) //Abrimos la conexión con la base de datos
			{
				//using va a crear una conexion y luego la va a destruir, de esta forma nos ahorramos futuros problemas de conexiones ya abiertas, 
				//y a parte, debido a que Dapper se ha creado especificamente para consultas SQL, nos ahorraremos MUCHO codigo.
				using (IDbConnection conexion = dbCon.Conexion) //ESTO ES DAPPER
				{
					//Insertamos en la tabla de empleado el nif nombreapellido y clave
					conexion.Execute($"INSERT INTO usuario (nombre_usuario, nombre, contraseña, correo) VALUES ('{usu.NombreUsuario}', '{ usu.Nombre }', '{ usu.Contraseña }', '{ usu.Correo }');");
				}
			}
		}

		public static void EliminarUsuario(string nomUsu, string pass) //Si el usuario quiere borrar su perfil, le pediremos la pass
		{
			var dbCon = DBConnection.Instancia();
			if(dbCon.Conectado())
			{
				using (IDbConnection conexion = dbCon.Conexion)
				{
					conexion.Execute($"DELETE FROM usuarios WHERE nombre_usuario = '{ nomUsu }' AND contraseña = '{ pass }';");
				}
			}
		}

        public static void ModificarUsuario(string nomUsu, string nombre, string bio, string pagWeb, int id) {
            var dbCon = DBConnection.Instancia();
            if (dbCon.Conectado()) {
                using (IDbConnection conexion = dbCon.Conexion) { //Modificamos todos los campos, para ello, los textbox correspondientes deben autorrellenarse, y solo se modificarán en los que el usuario realize cambios.
                    conexion.Execute($"UPDATE usuario set nombre_usuario = '{ nomUsu }', nombre = '{ nombre }', biografia = '{ bio }', pagina_web = '{ pagWeb }' WHERE id_usuario = '{ id }'");
                }
            }
        }

        public static void AgregarImagen(Imagen imagen) {
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) //Abrimos la conexión con la base de datos
            {
                //using va a crear una conexion y luego la va a destruir, de esta forma nos ahorramos futuros problemas de conexiones ya abiertas, 
                //y a parte, debido a que Dapper se ha creado especificamente para consultas SQL, nos ahorraremos MUCHO codigo.
                using (IDbConnection conexion = dbCon.Conexion) //ESTO ES DAPPER
                {
                    //Insertamos en la tabla de empleado el nif nombreapellido y clave
                    conexion.Execute($"INSERT INTO imagen (descripcion, imagen, id_usuario) VALUES ('{imagen.Descripcion}', '{ imagen.NewImage }', '{ imagen.IdUsuario }');");
                }
            }
        }
/*
		public static List<Usuario> BuscarNombreUsuario(string usu) //Comprueba si existe un usuario con x nombre de usuario
		{
			var dbCon = DBConnection.Instancia();
			if (dbCon.Conectado())
			{
				using (IDbConnection conexion = dbCon.Conexion)
				{
					var output = conexion.Query<Usuario>($"SELECT * FROM usuario WHERE nombre_usuario = '{ usu }';").ToList();
					return output;
				}
			}
            else return null;
		}

		public static List<Usuario> BuscarCorreo(string correo)
		{
			var dbCon = DBConnection.Instancia();
			if (dbCon.Conectado())
			{
				using (IDbConnection conexion = dbCon.Conexion)
				{
					var output = conexion.Query<Usuario>($"SELECT COUNT(*) FROM usuario WHERE correo = '{ correo }';").ToList();
					return output;
				}
			}
			else return null;
		}*/

        public static bool ComprobarUsuario(string nombreUsuario, string contrasenya)
        {
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) //Abrimos la conexión con la base de datos
            {
                //using va a crear una conexion y luego la va a destruir, de esta forma nos ahorramos futuros problemas de conexiones ya abiertas, 
                //y a parte, debido a que Dapper se ha creado especificamente para consultas SQL, nos ahorraremos MUCHO codigo.
                using (IDbConnection conexion = dbCon.Conexion) //ESTO ES DAPPER
                {
                    var output = conexion.Query<Usuario>($"SELECT nombre_usuario, contraseña FROM usuario WHERE nombre_usuario = '{ nombreUsuario}' AND contraseña= '{contrasenya}'").ToList();
                    if (output.Count != 0) {
                        return true;
                    }
                }
            }
            return false;
        }

		
    }
}
