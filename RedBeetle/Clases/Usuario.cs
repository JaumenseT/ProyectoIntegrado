using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Usuario {
		public int Id_Usuario { get; }
		public string Nombre_usuario { get; }
		public string Nombre { get; set; }
		public string Contraseña { get; set; }
		public string Biografia { get; }
		public string Correo { get; }
		public string Pagina_web { get; }


		public Usuario(string nombreUsuario, string nombre, string contraseña, string correo)
		{
			Nombre_usuario = nombreUsuario;
			Nombre = nombre;
			Contraseña = contraseña;
			Correo = correo;
		}

		public Usuario(int idUsuario , string nombreUsuario, string nombre, string contraseña, string biografia, string correo, string paginaWeb)
		{
			Id_Usuario = idUsuario;
			Nombre_usuario = nombreUsuario;
			Nombre = nombre;
			Contraseña = contraseña;
			Biografia = biografia;
			Correo = correo;
			Pagina_web = paginaWeb;
		}

		public Usuario()
		{
		}

      /*  public bool ValidarUsuario(string nomUsu)
		{
			var error = false;
			if (nomUsu == "") error = true;
			if (nomUsu.Length <= 5 || nomUsu.Length >= 16) error = true;
			foreach (char elem in nomUsu)
			{
				if (elem != "(A-Z, 0-9)") error = true;
			}
		}
        */

        private bool ValidarContraseña(string contraseña) {
            bool error = true;

            if (contraseña == "") error = false;
            if (contraseña.Length < 5) error = false;
            if (contraseña == Nombre_usuario) error = false;

            return error;
        }
	}
}
