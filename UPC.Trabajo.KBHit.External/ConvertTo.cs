using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPC.Trabajo.KBHit.External
{
    public class ConvertTo
    {
        public static byte[] ConvertStringToByteArray(String sTexto)
        {
            return (new UnicodeEncoding()).GetBytes(sTexto);
        }

        public static String ConvertByteArrayToString(byte[] bArreglo)
        {
            return Convert.ToBase64String(bArreglo);
        }
    }
}
