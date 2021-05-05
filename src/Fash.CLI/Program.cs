using System;
using System.Buffers.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Fash.Lib;

namespace Fash.CLI
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //args = new[] { "C:\\Users\\masla\\Downloads\\82951.jpg", "SHA512"};
            
            var filePath = args[0];
            var algorithm = args[1];
            
            IHashAlgorithm hashAlgorithm = algorithm switch
            {
                "SHA512" => new Sha512(),
                "SHA256" => new Sha256(),
                "MD5" => new Md5(),
                _ => new Sha256()
            };
            
            if (filePath != null)
            {
                using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                var hasher = new HasherBuilder()
                    .SetInput(fs)
                    .SetAlgorithm(hashAlgorithm)
                    .SetRepresentation(new Base64Representation())
                    .Build();

                var result = hasher.Hash();

                Console.WriteLine(result);
            }

            Console.WriteLine("Type a key to exit.");
            Console.ReadKey();

        }
    }
}
