using System.Text;
using Cryptology.Helpers;

namespace Cryptology.Ciphers
{
    public static class ShiftCipher
    {
        public static string Shift(string input, sbyte shift)
        {
            var output = new StringBuilder(input.Length);

            foreach (var character in input)
            {;
                output.Append((char)AddMod(character, shift));
            }

            return output.ToString();
        }

        public static sbyte AddMod(char c, sbyte shift)
        {
            if (CharHelper.IsSpaceOrEndln(c)) return (sbyte)c;

            if (char.IsUpper(c))
            {
                if (c + shift < 65)
                    return (sbyte)(c + shift + 26);

                if (c + shift > 90)
                    return (sbyte)(c + shift - 26);
            }

            if (char.IsLower(c))
            {
                if (c + shift < 97)
                    return (sbyte)(c + shift + 25);

                if (c + shift > 122)
                    return (sbyte)(c + shift - 26);
            }

            return (sbyte) (c + shift);
        }
    }
}
