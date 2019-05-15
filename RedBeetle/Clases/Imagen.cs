using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    class Imagen {
        private int idImagen;
        private string descripcion;
        private int likes;
        Usuario usuario = new Usuario();

        public int IdImagen { get { return idImagen; } }
        public string Descripcion { get { return descripcion; } }
        public int Likes { get { return likes; } }
        public Usuario Usuario { get { return usuario; } }

        public Imagen(Usuario usu) {
            usuario = usu;
        }


    }
}
