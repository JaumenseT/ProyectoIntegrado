using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using RedBeetle.Clases;

namespace RedBeetle.Clases {
    public class Imagen {
        private string descripcion;
        Image newImage = null;
        int id_usuario;
        public string Descripcion { get { return descripcion; } }
        public int IdUsuario { get { return id_usuario; } }
        public Image NewImage { get { return newImage; } }

        public Imagen(string descripcion, Image image, int id_usuario) {
            this.descripcion = descripcion;
            newImage = image;
            this.id_usuario = id_usuario;
        }

        /*Subir imagen a sql convertida.
        private void subirAvatar(string filePath)
        {
            byte[] avatar = convertirAvatarAByte(filePath);
            Query.Connection = ConexionBBDD.obtenerConexion();
            Query.CommandText = "UPDATE usuarios SET Avatar = @avatar WHERE NombreUsuario = '" + UOn.getNombre() + "'";
            Query.Parameters.Add("@avatar", MySqlDbType.MediumBlob, avatar.Length).Value = avatar;
            Query.ExecuteNonQuery();
        }

        public static byte[] convertirAvatarAByte(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] avatar = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return avatar;
        }

        //Para recoger la imagen de mysql y mostrarla en un picturebox.
        byte[] avatarByte = cargarAvatardesdeMYSQL();
        Imagen.Image = byteArrayToImage(avatarByte);
        private byte[] cargarAvatardesdeMYSQL()
        {
            Query.Connection = ConexionBBDD.obtenerConexion();
            Query.CommandText = "SELECT avatar FROM usuarios WHERE NombreUsuario = '" + UOn.getNombre() + "'";
            consultar = Query.ExecuteReader();
            if (consultar.Read())
            {
                byte[] avatarByte = (byte[])consultar["avatar"];
                return avatarByte;
            }
            return null;
        }
        public Image byteArrayToImage(byte[] byteAvatar)
        {
            MemoryStream ms = new MemoryStream(byteAvatar);
            Image devolverImagen = Image.FromStream(ms);
            return devolverImagen;
        }*/
    }
}
