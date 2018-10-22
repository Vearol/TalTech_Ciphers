using System.Collections.Generic;
using System.Linq;

namespace Cryptology.Helpers
{
    public static class CipherHelper
    {
        public static float CalculateIC(Dictionary<char, byte> lettersCount)
        {
            var charachterSum = 0f;

            foreach (var letterCount in lettersCount.Values)
            {
                charachterSum += letterCount * (letterCount - 1);
            }

            var allSum = lettersCount.Values.Sum(x => x);

            return charachterSum / (allSum * (allSum - 1));
        }

        public static Dictionary<char, byte> TextToLetterDictionary(string text)
        {
            var dict = new Dictionary<char, byte>();

            foreach (var character in text)
            {
                if (CharHelper.IsSpaceOrEndln(character)) continue;

                //todo
                //var lowercaseChar = char.ToLower(character);
                if (dict.ContainsKey(character))
                {
                    dict[character]++;
                    continue;
                }

                dict.Add(character, 1);
            }

            return dict;
        }
    }
}
