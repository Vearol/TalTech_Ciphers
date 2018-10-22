using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cryptology.Helpers;

namespace Cryptology.Ciphers
{
    public static class OnePadCipher
    {
        private const string EngLetterFrequancy = "etaoinshrdlcumwfgypbvkjxqz";
        
        private static Dictionary<char, char> _swapLettersDictionary = new Dictionary<char, char>();

        public static (string, Dictionary<char, char>, string) ReplaceLetterByFrequancy(string input, Dictionary<char, byte> letterFrequancy)
        {
            var output = new StringBuilder(input.Length);

            var frequency = letterFrequancy.OrderByDescending(x => x.Value).Select(x => x.Key).ToArray();

            foreach (var character in input)
            {
                if (CharHelper.IsSpaceOrEndln(character))
                {
                    output.Append(character);
                    continue;
                }

                var indexOfCharacterInCipherFreq = Array.IndexOf(frequency, character);

                var swapChar = EngLetterFrequancy[indexOfCharacterInCipherFreq];

                if (char.IsUpper(character))
                {
                    var swapCharUpper = char.ToUpper(swapChar);
                    output.Append(swapCharUpper);
                    AddToSwapLetterDict(character, swapCharUpper);

                    continue;
                }

                output.Append(swapChar);
                AddToSwapLetterDict(character, swapChar);
            }

            var s = "";
            for (var i = 0; i < frequency.Length; i++)
            {
                s += $"{char.ToUpper(EngLetterFrequancy[i])}: {frequency[i]}\n";
            }

            return (output.ToString(), _swapLettersDictionary, s);
        }

        private static void AddToSwapLetterDict(char character, char swapChar)
        {
            if (_swapLettersDictionary.ContainsKey(character))
                _swapLettersDictionary[character] = swapChar;
            else
                _swapLettersDictionary.Add(character, swapChar);
        }
    }
}
