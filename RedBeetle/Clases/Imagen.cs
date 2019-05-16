using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RedBeetle.Clases;

namespace RedBeetle.Clases {
    class Imagen {
        private string descripcion;
        //Image newImage = Image.FromFile(
        private Usuario usuario = new Usuario();

        public string Descripcion { get { return descripcion; } }
        public Usuario Usuario { get { return usuario; } }

        public Imagen(Usuario usu) {
            usuario = usu;
        }


    }
}
