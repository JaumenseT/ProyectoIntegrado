using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Usuario {

        private int id_usuario;
        private string nombre_usuario;
		private string nombre;
		private string contraseña;
		private string biografia;
		private string correo;
        private string pagina_web;

        public int IdUsuario { get { return id_usuario; } }
        public string NombreUsuario { get { return nombre_usuario; } }
        public string Nombre { get { return nombre; } }
        public string Contraseña { get { return contraseña; } }
		public string Biografia { get { return biografia; } }
		public string Correo { get { return correo; } }
		public string PaginaWeb {get { return pagina_web; } }

		public Usuario(string nombreUsuario, string nombre, string contrasenya, string correo)
		{
			this.nombre_usuario = nombreUsuario;
			this.nombre = nombre;
			this.contraseña = contrasenya;
			this.correo = correo;
		}

		public Usuario(int idUsuario, string nombreUsuario, string nombre, string contrasenya, string correo)
		{
            this.id_usuario = idUsuario;
			this.nombre_usuario = nombreUsuario;
			this.nombre = nombre;
			this.contraseña = contrasenya;
			this.correo = correo;
		}

		public Usuario(string nombreUsuario, string nombre, string contrasenya, string biografia, string correo)
		{
			this.nombre_usuario = nombreUsuario;
			this.nombre = nombre;
			this.contraseña = contrasenya;
			this.biografia = biografia;
			this.correo = correo;
		}

		public Usuario(int idUsuario , string nombreUsuario, string nombre, string contrasenya, string biografia, string correo, string paginaWeb)
		{
			this.id_usuario = idUsuario;
			this.nombre_usuario = nombreUsuario;
			this.nombre = nombre;
			this.contraseña = contrasenya;
			this.biografia = biografia;
			this.correo = correo;
			this.pagina_web = paginaWeb;
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
            if (contraseña == nombre_usuario) error = false;

            return error;
        }
	}
}
