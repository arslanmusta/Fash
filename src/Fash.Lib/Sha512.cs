using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Fash.Lib
{
    public class Sha512 : IHashAlgorithm
    {
        private readonly HashAlgorithm _hashAlgorithm = new SHA512Managed();
        
        public byte[] Compute(Stream input)
        {
            return _hashAlgorithm.ComputeHash(input);
        }
    }
}
