using System.Linq;

namespace Encoder
{
    public class EncodeHelper
    {
        public string ROTEncode(string input)
        {
            var charArray = input.ToCharArray();
            var encodeString = charArray.Select<char, char>(x => CharEncode(x)).ToArray();

            return new string(encodeString);

        }

        private char CharEncode(char plainText)
        {
            var asillCode = (int) plainText;
            if (asillCode >= 97 && asillCode <= 122)
                return (char)((asillCode-97+13)%26+97);
            if (asillCode >= 65 && asillCode <= 90)
                return (char)((asillCode - 65 + 13) % 26 + 65);

            return plainText;
        }
    }
}