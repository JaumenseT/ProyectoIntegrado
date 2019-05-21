using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Categoria {
        private string nombre;

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public Categoria(string nombre) {
            this.nombre = nombre;
        }
    }
}
