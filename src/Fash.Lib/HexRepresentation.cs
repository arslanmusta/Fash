using System;
using System.Collections.Generic;
using System.Text;

namespace Fash.Lib
{
    public class HexRepresentation : IRepresentation
    {
        private string _formatString = "x2";

        public bool IsUppercase
        {
            get => _formatString == "X2";
            set => _formatString = value ? "X2" : "x2";
        }

        public string Represent(byte[] input)
        {
            var stringBuilder = new StringBuilder();

            foreach (var b in input)
            {
                stringBuilder.Append(b.ToString(_formatString));
            }

            return stringBuilder.ToString();
        }
    }
}
