using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Prenda {
        private string nombre;
        private string link;
        private int id_imagen;
        private Categoria c;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Link { get { return link; } set { link = value; } }
        public int Id_Imagen { get { return id_imagen; } set { id_imagen = value; } }
        public Categoria C { get { return c; } set { c = value; } }

        public Prenda(string nombre, string link, int id_imagen, Categoria c) {
            this.nombre = nombre;
            this.link = link;
            this.id_imagen = id_imagen;
            this.c = c;
        }
    }
}
