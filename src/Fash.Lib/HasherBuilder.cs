using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fash.Lib
{
    public class HasherBuilder : IHasherBuilder
    {
        private Stream _input;
        private Stream _salt;
        private IHashAlgorithm _hashAlgorithm;
        private IRepresentation _representation;

        public IHasherBuilder SetAlgorithm(IHashAlgorithm algorithm)
        {
            _hashAlgorithm = algorithm;
            return this;
        }

        public IHasherBuilder SetInput(string input)
        {
            return SetInput(Encoding.UTF8.GetBytes(input));
        }

        public IHasherBuilder SetInput(byte[] input)
        {
            return SetInput(new MemoryStream(input));
        }

        public IHasherBuilder SetInput(Stream input)
        {
            _input = input;
            return this;
        }

        public IHasherBuilder SetSalt(string salt)
        {
            return SetSalt(Encoding.UTF8.GetBytes(salt));
        }

        public IHasherBuilder SetSalt(byte[] salt)
        {
            return SetSalt(new MemoryStream(salt));
        }

        public IHasherBuilder SetSalt(Stream salt)
        {
            _salt = salt;
            return this;
        }

        public IHasherBuilder SetRepresentation(IRepresentation representation)
        {
            _representation = representation;
            return this;
        }

        public IHasherBuilder IsUppercase(bool isUppercase)
        {
            throw new NotImplementedException();
        }

        public IHasher Build()
        {
            return new Hasher(_hashAlgorithm, _representation, _input, _salt);
        }
    }
}
