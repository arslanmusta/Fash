using System;
using System.Collections.Generic;
using System.Text;

namespace Fash.Lib
{
    public interface IRepresentation
    {
        string Represent(byte[] input);
    }
}
