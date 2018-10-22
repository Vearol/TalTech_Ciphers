using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cryptology.Ciphers;
using Cryptology.Helpers;

namespace Cryptology
{
    public partial class Form1 : Form
    {
        private sbyte _shiftStep;
        private Dictionary<char, byte> _lettersCount = new Dictionary<char, byte>();

        public Form1()
        {
            InitializeComponent();

            cipherText.TextChanged += CipherTextChanged;
        }

        private void CipherTextChanged(object sender, EventArgs eventArgs)
        {
            _lettersCount = CipherHelper.TextToLetterDictionary(cipherText.Text);

            UpdateCharacterData();

            ICValue.Text = CipherHelper.CalculateIC(_lettersCount).ToString("0.00000");
        }

        private void RedrawChart()
        {
            lettersChart.Series["letters"].Points.Clear();
            foreach (var letter in _lettersCount.Keys)
            {
                lettersChart.Series["letters"].Points.AddXY(letter, _lettersCount[letter]);
            }
        }

        private void UpdateLetterLabel()
        {
            var s = "";
            var counter = 0;

            foreach (var letterCount in _lettersCount)
            {
                counter++;

                s += $"{letterCount.Key} {letterCount.Value}; ";

                if (counter > 20)
                {
                    s += '\n';
                    counter = 0;
                }
            } 

            letterMapLabel.Text = s;
        }

        private void ShiftRightButton_Click(object sender, EventArgs e)
        {
            _shiftStep ++;

            plainText.Text = ShiftCipher.Shift(cipherText.Text, _shiftStep);
        }

        private void ShiftLeftButton_Click(object sender, EventArgs e)
        {
            _shiftStep --;

            plainText.Text = ShiftCipher.Shift(cipherText.Text, _shiftStep);
        }

        private void AddEngLetters_Click(object sender, EventArgs e)
        {
            for (var i = 97; i <= 122; i++)
            {
                var character = (char) i;

                if (!_lettersCount.ContainsKey(character))
                    _lettersCount.Add(character, 0);
            }

            UpdateCharacterData();
        }

        private void RemoveENGCharacters_Click(object sender, EventArgs e)
        {
            var keysToRemove = _lettersCount.Where(x => x.Value == 0).Select(x => x.Key).ToArray();
            foreach (var key in keysToRemove)
            {
                _lettersCount.Remove(key);
            }

            UpdateCharacterData();
        }

        private void ClearCipherText_Click(object sender, EventArgs e)
        {
            cipherText.Text = "";
            plainText.Text = "";
            _lettersCount.Clear();
            ICValue.Text = "none";
            UpdateCharacterData();
        }

        private void UpdateCharacterData()
        {
            RedrawChart();
            UpdateLetterLabel();
        }

        private void OnePadOneButton_Click(object sender, EventArgs e)
        {
            (var text, var swapLetterDict, var compareFreq) = OnePadCipher.ReplaceLetterByFrequancy(cipherText.Text, _lettersCount);

            plainText.Text = text;

            var str = "";
            var counter = 0;

            foreach (var swapChar in swapLetterDict)
            {
                str += $"{swapChar.Key} -> {swapChar.Value}       ";
                counter++;

                if (counter >= 3)
                {
                    str += '\n';
                    counter = 0;
                }
            }

            letterSwapLabel.Text = str;
            labelFrequancyLabel.Text = compareFreq;
        }

        private void ReplacePatternButton_Click(object sender, EventArgs e)
        {
            var replacedText = VigenereCipher.ReplaceStrings(cipherText.Text, oldPatternTextBox.Text, newPatternTextBox.Text);
            plainText.Text = replacedText;

            currentVigenereStep.Text = $"Current key letters: \n{VigenereCipher.GetCurrentKeyLetters()}";
        }

        private void VigenereICKeySearchButton_Click(object sender, EventArgs e)
        {
            possibleKeyCharcters.Text = VigenereCipher.CheckICForLetter(cipherText.Text, byte.Parse(possibleKeyCount.Text));
        }

        private void TryVigenereKeyButton_Click(object sender, EventArgs e)
        {
            plainText.Text = VigenereCipher.DecryptWithKey(cipherText.Text, decryptionKeyTextBox.Text);
        }

        private void AddCharToKey_Click(object sender, EventArgs e)
        {
            decryptionKeyTextBox.Text += 'A';
        }

        private void IncreaseLastWord_Click(object sender, EventArgs e)
        {
            IncreaseKeyAndApply(1);
            UpdateKeyData();
        }

        private void IncreaseKeyAndApply(sbyte step)
        {
            var keyLength = decryptionKeyTextBox.Text.Length;

            var oldKeyLastChar = decryptionKeyTextBox.Text[keyLength - 1];
            var newKey = decryptionKeyTextBox.Text.Remove(keyLength - 1) + (char)ShiftCipher.AddMod(oldKeyLastChar, step);

            decryptionKeyTextBox.Text = newKey;
            plainText.Text = VigenereCipher.DecryptWithKey(cipherText.Text, newKey);
        }

        private void UpdateKeyData()
        {
            encryptionKeyLabel.Text = $"Encryption key: {VigenereCipher.EncryptionKey}";
            decryptionKeyLabel.Text = $"Decryption key: {VigenereCipher.DecryptionKey}";
        }

        private void DecreaseLastWord_Click(object sender, EventArgs e)
        {
            IncreaseKeyAndApply(-1);
            UpdateKeyData();
        }
    }
}
