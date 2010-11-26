using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Cryptography;

namespace UPC.Trabajo.KBHit.External
{
    public class Cryptography
    {
        public static String GetMD5Hash(String sContrasenia)
        {
            byte[] MD5Hash = null;

            MD5Hash = MD5.Create().ComputeHash(ConvertTo.ConvertStringToByteArray(sContrasenia));

            return ConvertTo.ConvertByteArrayToString(MD5Hash);
        }
    }
}
