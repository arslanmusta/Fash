using System;
using System.Buffers.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Fash.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new[] { "C:\\Users\\masla\\Downloads\\82951.jpg", "MD5"};
            
            var filePath = args[0];
            var algorithm = args[1];

            HashAlgorithm hashAlgorithm = new SHA1Managed();

            if (algorithm == "SHA512")
            {
                hashAlgorithm = new SHA512Managed();
            }
            else if (algorithm == "SHA256")
            {
                hashAlgorithm = new SHA256Managed();
            }
            else if (algorithm == "MD5")
            {
                hashAlgorithm = new MD5CryptoServiceProvider();
            }



            if (filePath != null) 
            {
                
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    var hash = hashAlgorithm.ComputeHash(fs);
                    //var base64 = Convert.ToBase64String(hash);
                    //Console.WriteLine(base64);

                    var stringBuilder = new StringBuilder();
                    
                    foreach (var b in hash)
                    {
                        stringBuilder.Append(b.ToString("x2"));
                    }

                    Console.WriteLine(stringBuilder.ToString());
                }
            }
        }
    }
}
