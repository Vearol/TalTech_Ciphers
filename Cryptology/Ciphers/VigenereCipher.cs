using System.Collections.Generic;
using System.Text;
using Cryptology.Helpers;

namespace Cryptology.Ciphers
{
    public static class VigenereCipher
    {
        private static List<KeyValuePair<char, char>> _trackingSwaps = new List<KeyValuePair<char, char>>();
        public static string DecryptionKey;
        public static string EncryptionKey;

        public static string ReplaceStrings(string input, string oldPattern, string newPattern)
        {
            _trackingSwaps.Clear();
            var inputCopy = input;

            for (var i = 0; i < oldPattern.Length; i++)
            {
                _trackingSwaps.Add(new KeyValuePair<char, char>(oldPattern[i], newPattern[i]));
            }

            return inputCopy.Replace(oldPattern, newPattern);
        }

        public static string GetCurrentKeyLetters()
        {
            var str = "";
            DecryptionKey = "";
            EncryptionKey = "";

            foreach (var trackingSwap in _trackingSwaps)
            {
                var decryptionKeyChar = (char)(90 - (trackingSwap.Key - trackingSwap.Value));
                var encryptionKeyChar = (char)(65 + (trackingSwap.Key - trackingSwap.Value));

                DecryptionKey += decryptionKeyChar;
                EncryptionKey += encryptionKeyChar;

                str += $"Decr: {decryptionKeyChar}        Encr: {encryptionKeyChar}\n";
            }

            return str;
        }

        public static string CheckICForLetter(string inputText, byte letterKeySize)
        {
            var str = "";

            for (var i = 0; i < letterKeySize; i++)
            {
                var maxIC = -1f;
                var mostProbableCharacter = '-';

                for (sbyte j = 0; j < 26; j++)
                {
                    var inputTextCopy = inputText;
                    var currentIC = CipherHelper.CalculateIC(CipherHelper.TextToLetterDictionary(ShiftCipher.Shift(inputTextCopy, j)));

                    if (currentIC > maxIC)
                    {
                        maxIC = currentIC;
                        mostProbableCharacter = (char)(65 + j);
                    }
                }

                str += $"{mostProbableCharacter} - {maxIC.ToString("0.0000")}\n";
            }

            return str;
        }

        public static string DecryptWithKey(string input, string key)
        {
            var plainText = new StringBuilder();

            for (var i = 0; i < input.Length; i++)
            {
                var character = input[i];
                var keyDecodeChar = key[i % key.Length];

                plainText.Append((char)ShiftCipher.AddMod(character, (sbyte)(keyDecodeChar - 64)));
            }

            DecryptionKey = key;
            EncryptionKey = GetEncryptionKey(key);

            return plainText.ToString();
        }

        private static string GetEncryptionKey(string decryptionKey)
        {
            var encryptionKey = new StringBuilder();

            foreach (var character in decryptionKey)
            {
                encryptionKey.Append((char)(65 + (90 - character)));
            }

            return encryptionKey.ToString();
        }
    }
}
