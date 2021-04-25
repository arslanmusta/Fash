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
            
            HashAlgorithm hashAlgorithm = algorithm switch
            {
                "SHA512" => new SHA512Managed(),
                "SHA256" => new SHA256Managed(),
                "MD5" => new MD5CryptoServiceProvider(),
                _ => new SHA1Managed()
            };
            
            if (filePath != null)
            {
                using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                var hash = hashAlgorithm.ComputeHash(fs);

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
