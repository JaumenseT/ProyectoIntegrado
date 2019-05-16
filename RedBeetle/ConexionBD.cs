using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle {
    class ConexionBD {
            // Atributo para gestionar la conexión.
            private MySqlConnection conexion;

            // Propiedad para acceder a la conexión.
            public MySqlConnection Conexion { get { return conexion; } }

            // Constructor que instancia la conexión, definiendo la cadena de conexión (ConnectionString)

            // Define la conexión a la base de datos mediante los atributos del constructor
            public ConexionBD() {
                string server = "server=3.15.23.32;";
                string port = "port=3306;";
                string database = "database=proyecto_integrado;";
                string usuario = "uid=redbeetle;";
                string password = "pwd=ZUlxPGKUV4;";
                string connectionstring = server + port + database + usuario + password;
                conexion = new MySqlConnection(connectionstring);
            }

            // Método que se encarga de abrir la conexión
            // Devuelve true/false dependiendo si la conexión se ha abierto con éxito o no
            public bool AbrirConexion() {
                try {
                    conexion.Open();
                    return true;
                }
                catch (MySqlException ex)  // Inicialmente no es necesario utilizar el objeto ex
                {
                    return false;
                }
            }

            // Método que se encarga de cerrar la conexión (evitar dejar conexiones abiertas)
            // Devuelve true/false dependiendo si la conexión se ha cerrado con éxito
            public bool CerrarConexion() {
                try {
                    conexion.Close();
                    return true;
                }
                catch (MySqlException ex) // Inicialmente no es necesario utilizar el objeto ex
                {
                    return false;
                }
            }

        }
    }
}
