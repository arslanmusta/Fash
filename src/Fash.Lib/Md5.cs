using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Fash.Lib
{
    public class Md5 : IHashAlgorithm
    {
        private readonly HashAlgorithm _hashAlgorithm = new MD5CryptoServiceProvider();
        public byte[] Compute(Stream input)
        {
            return _hashAlgorithm.ComputeHash(input);
        }
    }
}
