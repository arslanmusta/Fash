using System;
using System.Collections.Generic;
using System.Text;

namespace Fash.Lib
{
    public class Base64Representation : IRepresentation
    {
        public string Represent(byte[] input)
        {
            return Convert.ToBase64String(input);
        }
    }
}
