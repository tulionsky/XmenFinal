using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace XmenFinal.Data.Models
{
    internal class imagen
    {

        //convertir bytes a imagen
        public static MemoryStream ByteToImagen(byte[] array)
        {
            MemoryStream ms = new MemoryStream((byte[])array);
            return ms;
        }

        //convierte imagen a byte
        public static byte[] ImageToByte(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, ImageFormat.Png);

            return ms.ToArray();
        }
    }
}
