using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBeetle.Clases {
    public class Aplicacion {
        static private Usuario user = null;

        static public Usuario User { get { return user; } set { user = value; } }
    }
}
