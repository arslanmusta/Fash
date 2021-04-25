using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Fash.Lib
{
    public class Sha1 : IHashAlgorithm
    {
        private readonly HashAlgorithm _hashAlgorithm = new SHA1Managed();
        public byte[] Compute(Stream input)
        {
            return _hashAlgorithm.ComputeHash(input);
        }
    }
}
