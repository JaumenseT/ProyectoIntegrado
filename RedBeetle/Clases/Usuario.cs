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
		public string Contrasenya { get; set; }
        public byte[] Foto_Perfil { get; set; }
		public string Biografia { get; }
		public string Correo { get; }
		public string Pagina_web { get; }

		public Usuario(string nombreUsuario, string nombre, string contraseña, string correo)
		{
			Nombre_usuario = nombreUsuario;
			Nombre = nombre;
			Contrasenya = contraseña;
			Correo = correo;
		}

		public Usuario(int idUsuario , string nombreUsuario, string nombre, string contraseña, string biografia, string correo, string paginaWeb, byte[] foto_perfil)
		{
			Id_Usuario = idUsuario;
			Nombre_usuario = nombreUsuario;
			Nombre = nombre;
			Contrasenya = contraseña;
			Biografia = biografia;
			Correo = correo;
			Pagina_web = paginaWeb;
            Foto_Perfil = foto_perfil;
		}

		public Usuario()
		{
		}
	}
}
