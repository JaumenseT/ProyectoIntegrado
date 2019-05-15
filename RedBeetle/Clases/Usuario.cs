using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Usuario {

        private string nombreUsuario;
		private string nombre;
		private string contrasenya;
		private string biografia;
		private string correo;
        private string paginaWeb;

        public string NombreUsuario { get { return nombreUsuario; } }
        public string Nombre { get { return nombre; } }
        public string Contrasenya { get { return contrasenya; } }
		public string Biografia { get { return biografia; } }
		public string Correo { get { return correo; } }
		public string PaginaWeb {get { return paginaWeb; } }

		public Usuario(string nombreUsuario, string nombre, string contrasenya, string correo)
		{
			this.nombreUsuario = nombreUsuario;
			this.nombre = nombre;
			this.contrasenya = contrasenya;
			this.correo = correo;
		}

		public Usuario(string nombreUsuario, string nombre, string contrasenya, string biografia, string correo)
		{
			this.nombreUsuario = nombreUsuario;
			this.nombre = nombre;
			this.contrasenya = contrasenya;
			this.biografia = biografia;
			this.correo = correo;
		}

		public Usuario(string nombreUsuario, string nombre, string contrasenya, string biografia, string correo, string paginaWeb)
		{
			this.nombreUsuario = nombreUsuario;
			this.nombre = nombre;
			this.contrasenya = contrasenya;
			this.biografia = biografia;
			this.correo = correo;
			this.paginaWeb = paginaWeb;
		}

		public Usuario()
		{
		}

        public bool ValidarUsuario(string nomUsu)
		{
			var error = false;
			if (nomUsu == "") error = true;
			if (nomUsu.Length <= 5 || nomUsu.Length >= 16) error = true;
			foreach (char elem in nomUsu)
			{
				if (elem != "(A-Z, 0-9)") error = true;
			}
		}


        private bool ValidarContraseña(string contraseña) {
            bool error = true;

            if (contraseña == "") error = false;
            if (contraseña.Length < 5) error = false;
            if (contraseña == nombreUsuario) error = false;

            return error;
        }
	}
}
