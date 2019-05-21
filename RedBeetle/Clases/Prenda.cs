using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Prenda {
        private string nombre;
        private string link;
        private Imagen image;
        private Categoria c;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Link { get { return link; } set { link = value; } }
        public Imagen Image { get { return image; } set { image = value; } }
        public Categoria C { get { return c; } set { c = value; } }

        public Prenda(string nombre, string link, Imagen image, Categoria c) {
            this.nombre = nombre;
            this.link = link;
            this.image = image;
            this.c = c;
        }
    }
}
