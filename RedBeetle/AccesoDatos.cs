using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Collections;
using Dapper;
using RedBeetle.Clases;

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
		public static void AgregarUsuario(Usuario usu) //EJEMPLO DE FUNCION USANDO DAPPER
		{
			var dbCon=DBConnection.Instancia(); //Instanciamos la conexión con la base de datos usando la clase DBConnection.
			if (dbCon.Conectado()) //Abrimos la conexión con la base de datos
			{
				//using va a crear una conexion y luego la va a destruir, de esta forma nos ahorramos futuros problemas de conexiones ya abiertas, 
				//y a parte, debido a que Dapper se ha creado especificamente para consultas SQL, nos ahorraremos MUCHO codigo.
				using (IDbConnection conexion = dbCon.Conexion) //ESTO ES DAPPER
				{
					//Insertamos en la tabla de empleado el nif nombreapellido y clave
					conexion.Execute($"INSERT INTO usuario (nombre_usuario, nombre, contraseña, correo) VALUES ('{usu.NombreUsuario}', '{ usu.Nombre }', '{ usu.Contrasenya }', '{ usu.Correo }');");
				}
			}
		}

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
