using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RedBeetle
{
	/// <summary>
	/// Clase que establecerá la conexión con la base de datos
	/// </summary>
	public class DBConnection
	{
		private DBConnection()
		{
		}

		private MySqlConnection conexion = null; //Al setear la conexion a null, cada vez que se cree un nuevo objeto DBConnection(Una nueva conexion)
		//se destruirá el anterior.

		/// <summary>
		/// Propiedad para establecer la conexión
		/// </summary>
		public MySqlConnection Conexion { get { return conexion; } }

		/// <summary>
		/// /Al ser null, siempre se destruira la conexion al dejar de usarla
		/// </summary>
		private static DBConnection instancia = null;

		/// <summary>
		/// Si no hemos instanciado la base de datos, creamos una
		/// </summary>
		/// <returns></returns>
		public static DBConnection Instancia()
		{

			if (instancia == null) instancia = new DBConnection();

			return instancia;
		}

		/// <summary>
		/// Función para conectar con la base de datos
		/// </summary>
		/// <returns>Nos dice si nos hemos conectado</returns>
		public bool Conectado()
		{
			if (Conexion == null)
			{
				try
				{
                    //Query de la base de datos remota
                    string consulta = string.Format("Server=3.15.23.32; port=3306; database=proyecto_integrado; user=redbeetle; pwd=ZUlxPGKUV4; old guids=true");
                    //string consulta = string.Format("Server=localhost; port=3306; database=proyecto_integrado; user=root; pwd=; old guids=true");
                    conexion = new MySqlConnection(consulta); //Pasamos la query 
					conexion.Open(); //Abrimos conexión
				}
				catch //Si no se puede abrir la conexión
				{
					System.Windows.Forms.MessageBox.Show("No se ha podido conectar con la base de datos.");
					System.Windows.Forms.Application.Exit(); //Cerramos la aplicación
					return false;
				}

			}
			return true;
		}

		/// <summary>
		/// Función para cerrar la conexión
		/// </summary>
		public void Close()
		{
			conexion.Close();
		}
	}
}