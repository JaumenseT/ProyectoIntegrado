using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Categoria {
        private int id_categoria;
        private string nombre;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Id_Categoria { get { return id_categoria; } set { Id_Categoria = value; } }

        public Categoria(string nombre, int id_categoria) {
            this.nombre = nombre;
            this.id_categoria = id_categoria;
        }
    }
}
