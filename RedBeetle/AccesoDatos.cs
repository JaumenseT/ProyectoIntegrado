﻿using System;
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
		/// <summary>
		/// Metodo que devolvera un usuario entero segun el nombre de usuario suministrado
		/// </summary>
		/// <param name="nombreUsuario"></param>
		/// <returns></returns>
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

        public static Usuario DevolverUsuario(int id_usuario) {
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) { //Abrimos la conexión con la base de datos 
                using (IDbConnection conexion = dbCon.Conexion) {
                    var output = conexion.Query<Usuario>($"SELECT * FROM usuario WHERE id_usuario = '{ id_usuario }';").ToList();
                    if (output.Count != 0) {
                        Usuario usu = output[0];
                        return usu;

                    } else return null;

                }
            } else return null;
        }

        /// <summary>
        /// Metodo que comprueba si existe un correo
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public static bool ExisteCorreo(string correo)
		{
			var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
			if (dbCon.Conectado())
			{ //Abrimos la conexión con la base de datos 
				using (IDbConnection conexion = dbCon.Conexion)
				{
					var output = conexion.Query<string>($"SELECT correo FROM usuario WHERE correo = '{ correo }';").ToList();
					if (output.Count == 0) return false;
					else return true;
				}
			}
			else return false;
		}

		/// <summary>
		/// Metodo que devuelve una lista de strings con TODOS los nombres de usuario de la base de datos de todos los usarios
		/// </summary>
		/// <returns></returns>
		public static List<string> DevolverNombresUsuario()
		{
			var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
			if (dbCon.Conectado())
			{ //Abrimos la conexión con la base de datos 
				using (IDbConnection conexion = dbCon.Conexion)
				{
					var output = conexion.Query<string>($"SELECT nombre_usuario FROM usuario;").ToList();
					return output;
				}
			}
			else return null;
		}

		/// <summary>
		/// Metodo que devuelve un array de bytes con todas las imagenes del usuario suministrado por parametro
		/// </summary>
		/// <param name="nomUsu"></param>
		/// <returns></returns>
		public static List<Imagen> DevolverImagenes(string nomUsu)
		{
			var dbCon = DBConnection.Instancia();
			if (dbCon.Conectado())
			{
				using (IDbConnection conexion = dbCon.Conexion)
				{
					var output = conexion.Query<Imagen>($"SELECT i.id_imagen, i.descripcion, i.imagenes, i.id_usuario FROM imagen i INNER JOIN usuario u ON i.id_usuario = u.id_usuario WHERE u.nombre_usuario = '{ nomUsu }';").ToList();
					return output;
				}
			}
			else return null;
		}

		/// <summary>
		/// Metodo que devuelve un array de bytes con todas las imagenes de todos los usuarios menos del logeado
		/// </summary>
		/// <param name="nomUsu"></param>
		/// <returns></returns>
		public static List<Imagen> DevolverTodasImagenes(string nomUsu)
		{
			var dbCon = DBConnection.Instancia();
			if (dbCon.Conectado())
			{
				using (IDbConnection conexion = dbCon.Conexion)
				{
					var output = conexion.Query<Imagen>($"SELECT  i.id_imagen, i.descripcion, i.imagenes, i.id_usuario FROM imagen i INNER JOIN usuario u ON i.id_usuario = u.id_usuario WHERE u.nombre_usuario != '{ nomUsu }' ORDER BY RAND();").ToList();
					return output;
				}
			}
			else return null;
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
					conexion.Execute($"INSERT INTO usuario (nombre_usuario, nombre, contrasenya, correo) VALUES ('{usu.Nombre_usuario}', '{ usu.Nombre }', '{ usu.Contrasenya }', '{ usu.Correo }');");
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
					conexion.Execute($"DELETE FROM usuarios WHERE nombre_usuario = '{ nomUsu }' AND contrasenya = '{ pass }';");
				}
			}
		}

        public static void ModificarUsuario(string nomUsu, string nombre, string bio, string pagWeb, int id, byte[] imagen) {
            var dbCon = DBConnection.Instancia();
            if (dbCon.Conectado()) {
                using (IDbConnection conexion = dbCon.Conexion) { //Modificamos todos los campos, para ello, los textbox correspondientes deben autorrellenarse, y solo se modificarán en los que el usuario realize cambios.
                    conexion.Execute($"UPDATE usuario set nombre_usuario = '{ nomUsu }', nombre = '{ nombre }', biografia = '{ bio }', pagina_web = '{ pagWeb }', foto_perfil = @foto_perfil WHERE id_usuario = '{ id }'", new { foto_perfil = imagen });
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
                    conexion.Execute($"INSERT INTO imagen (descripcion, imagenes, id_usuario) VALUES (@descripcion, @img, @id);", new { descripcion = imagen.Descripcion, img = imagen.ImageBytes, id = imagen.IdUsuario });
                }
            }
        }

        public static void AgregarPrenda(Prenda prenda) {
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) //Abrimos la conexión con la base de datos
            {
                //using va a crear una conexion y luego la va a destruir, de esta forma nos ahorramos futuros problemas de conexiones ya abiertas, 
                //y a parte, debido a que Dapper se ha creado especificamente para consultas SQL, nos ahorraremos MUCHO codigo.
                using (IDbConnection conexion = dbCon.Conexion) //ESTO ES DAPPER
                {
                    //Insertamos en la tabla de empleado el nif nombreapellido y clave
                    conexion.Execute($"INSERT INTO prenda (nombre, link, id_imagen, id_categoria) VALUES (@nombre, @link, @id_imagen, @id_categoria);", new { nombre = prenda.Nombre, link = prenda.Link, id_imagen = prenda.Id_Imagen, id_categoria = prenda.C.Id_Categoria });
                }
            }
        }

        public static Categoria DevolverCategoria(string nombreCategoria) {
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) { //Abrimos la conexión con la base de datos 
                using (IDbConnection conexion = dbCon.Conexion) {
                    var output = conexion.Query<Categoria>($"SELECT nombre, id_categoria FROM categoria WHERE nombre = @nombre;", new { nombre = nombreCategoria }).ToList();
                    if (output.Count != 0) {
                        Categoria c = output[0];
                        return c;

                    } else return null;

                }
            } else return null;
        }

        public static int DevolverUltimoInsert() {
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) { //Abrimos la conexión con la base de datos 
                using (IDbConnection conexion = dbCon.Conexion) {
                    var output = conexion.Query<int>($"SELECT LAST_INSERT_ID()").ToList();
                    if (output.Count != 0) {
                        int Ultimaimagen = output[0];
                        return Ultimaimagen;
                    } else return 0;
                }
            } else return 0;
        }

        public static Prenda DevolverPrenda(int idImagen, int idCategoria) {
            var dbCon = DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
            if (dbCon.Conectado()) { //Abrimos la conexión con la base de datos 
                using (IDbConnection conexion = dbCon.Conexion) {
                    var output = conexion.Query<Prenda>($"SELECT nombre, link, id_imagen FROM prenda WHERE id_imagen = @id_imagen AND id_categoria = @id_categoria", new { id_imagen = idImagen, id_categoria = idCategoria }).ToList();
                    if (output.Count != 0) {
                        Prenda p = output[0];
                        return p;

                    } else return null;

                }
            } else return null;
        }
    }
}
