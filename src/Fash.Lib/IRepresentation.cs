using System;
using System.Collections.Generic;
using System.Text;

namespace Fash.Lib
{
    public interface IRepresentation
    {
        bool IsUppercase { get; set; }
        string Represent(byte[] input);
    }
}
