using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fash.Lib
{
    public interface IHasherBuilder
    {
        IHasherBuilder SetAlgorithm(IHashAlgorithm algorithm);

        IHasherBuilder SetInput(string input);

        IHasherBuilder SetInput(byte[] input);

        IHasherBuilder SetInput(Stream input);

        IHasherBuilder SetSalt(string salt);

        IHasherBuilder SetSalt(byte[] salt);

        IHasherBuilder SetSalt(Stream salt);

        IHasherBuilder SetRepresentation(IRepresentation representation);

        IHasherBuilder IsUppercase(bool isUppercase);

        IHasher Build();
    }
}
