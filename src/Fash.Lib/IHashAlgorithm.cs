using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fash.Lib
{
    public interface IHashAlgorithm
    {
        byte[] Compute(Stream input);
    }
}
