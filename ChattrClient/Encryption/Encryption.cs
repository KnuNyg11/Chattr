using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ChattrClient.Encryption
{
    class Encryption
    {
        byte[] Key { get; set; }
        byte[] IV { get; set; }
        
        public Encryption()
        {
            using(RijndaelManaged rm = new RijndaelManaged())
            {
                rm.GenerateKey();
                rm.GenerateIV();

                Key = rm.Key;
                IV = rm.IV;
            }
        }

        public byte[] Encrypt(byte[] data)
        {
            byte[] encryptedData;
            
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (CryptoStream cs = new CryptoStream(ms, null, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    encryptedData = ms.ToArray();
                }
            }
            

            return encryptedData;
        }
    }
}
