using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fash.Lib
{
    public class Hasher : IHasher
    {
        private readonly IHashAlgorithm _hashAlgorithm;
        private readonly IRepresentation _representation;
        private readonly Stream _input;
        private readonly Stream _salt;

        internal Hasher(IHashAlgorithm hashAlgorithm, IRepresentation representation, Stream input, Stream salt)
        {
            _hashAlgorithm = hashAlgorithm;
            _representation = representation;
            _input = input;
            _salt = salt;
        }

        public string Hash()
        {
            _input.Position = _input.Length;
            _salt?.CopyTo(_input);

            var hash = _hashAlgorithm.Compute(_input);

            return _representation.Represent(hash);
        }
    }
}
