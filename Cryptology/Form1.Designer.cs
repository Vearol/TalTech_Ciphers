using System.Windows.Forms;

namespace Cryptology
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ciphers = new System.Windows.Forms.TabControl();
            this.basicInfo = new System.Windows.Forms.TabPage();
            this.letterMapLabel = new System.Windows.Forms.Label();
            this.removeENGCharacters = new System.Windows.Forms.Button();
            this.addEngLetters = new System.Windows.Forms.Button();
            this.ICValue = new System.Windows.Forms.Label();
            this.ICLabel = new System.Windows.Forms.Label();
            this.lettersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shiftTab = new System.Windows.Forms.TabPage();
            this.shiftLeftButton = new System.Windows.Forms.Button();
            this.shiftRightButton = new System.Windows.Forms.Button();
            this.onepad = new System.Windows.Forms.TabPage();
            this.labelFrequancyLabel = new System.Windows.Forms.Label();
            this.letterSwapLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.onePadOneButton = new System.Windows.Forms.Button();
            this.affineTab = new System.Windows.Forms.TabPage();
            this.vigenereTab = new System.Windows.Forms.TabPage();
            this.decreaseLastWord = new System.Windows.Forms.Button();
            this.increaseLastWord = new System.Windows.Forms.Button();
            this.addCharToKey = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.possibleKeyCharcters = new System.Windows.Forms.Label();
            this.calculateICforVigenereKeyButton = new System.Windows.Forms.Button();
            this.possibleKeyCount = new System.Windows.Forms.TextBox();
            this.currentVigenereStep = new System.Windows.Forms.Label();
            this.tryVigenereKeyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.decryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.replacePatternButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newPatternTextBox = new System.Windows.Forms.TextBox();
            this.oldPatternTextBox = new System.Windows.Forms.TextBox();
            this.cipherText = new System.Windows.Forms.RichTextBox();
            this.plainText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearCipherText = new System.Windows.Forms.Button();
            this.decryptionKeyLabel = new System.Windows.Forms.Label();
            this.encryptionKeyLabel = new System.Windows.Forms.Label();
            this.ciphers.SuspendLayout();
            this.basicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lettersChart)).BeginInit();
            this.shiftTab.SuspendLayout();
            this.onepad.SuspendLayout();
            this.vigenereTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ciphers
            // 
            this.ciphers.Controls.Add(this.basicInfo);
            this.ciphers.Controls.Add(this.shiftTab);
            this.ciphers.Controls.Add(this.onepad);
            this.ciphers.Controls.Add(this.affineTab);
            this.ciphers.Controls.Add(this.vigenereTab);
            this.ciphers.Location = new System.Drawing.Point(2, 196);
            this.ciphers.Name = "ciphers";
            this.ciphers.SelectedIndex = 0;
            this.ciphers.Size = new System.Drawing.Size(764, 388);
            this.ciphers.TabIndex = 0;
            // 
            // basicInfo
            // 
            this.basicInfo.Controls.Add(this.letterMapLabel);
            this.basicInfo.Controls.Add(this.removeENGCharacters);
            this.basicInfo.Controls.Add(this.addEngLetters);
            this.basicInfo.Controls.Add(this.ICValue);
            this.basicInfo.Controls.Add(this.ICLabel);
            this.basicInfo.Controls.Add(this.lettersChart);
            this.basicInfo.Location = new System.Drawing.Point(4, 22);
            this.basicInfo.Name = "basicInfo";
            this.basicInfo.Size = new System.Drawing.Size(756, 362);
            this.basicInfo.TabIndex = 3;
            this.basicInfo.Text = "basic Info";
            this.basicInfo.UseVisualStyleBackColor = true;
            // 
            // letterMapLabel
            // 
            this.letterMapLabel.AutoSize = true;
            this.letterMapLabel.Location = new System.Drawing.Point(21, 295);
            this.letterMapLabel.Name = "letterMapLabel";
            this.letterMapLabel.Size = new System.Drawing.Size(0, 13);
            this.letterMapLabel.TabIndex = 7;
            // 
            // removeENGCharacters
            // 
            this.removeENGCharacters.Location = new System.Drawing.Point(602, 3);
            this.removeENGCharacters.Name = "removeENGCharacters";
            this.removeENGCharacters.Size = new System.Drawing.Size(151, 34);
            this.removeENGCharacters.TabIndex = 6;
            this.removeENGCharacters.Text = "Remove ENG Characters";
            this.removeENGCharacters.UseVisualStyleBackColor = true;
            this.removeENGCharacters.Click += new System.EventHandler(this.RemoveENGCharacters_Click);
            // 
            // addEngLetters
            // 
            this.addEngLetters.Location = new System.Drawing.Point(445, 3);
            this.addEngLetters.Name = "addEngLetters";
            this.addEngLetters.Size = new System.Drawing.Size(151, 34);
            this.addEngLetters.TabIndex = 5;
            this.addEngLetters.Text = "Add ENG Characters";
            this.addEngLetters.UseVisualStyleBackColor = true;
            this.addEngLetters.Click += new System.EventHandler(this.AddEngLetters_Click);
            // 
            // ICValue
            // 
            this.ICValue.AutoSize = true;
            this.ICValue.Location = new System.Drawing.Point(53, 11);
            this.ICValue.Name = "ICValue";
            this.ICValue.Size = new System.Drawing.Size(31, 13);
            this.ICValue.TabIndex = 4;
            this.ICValue.Text = "none";
            // 
            // ICLabel
            // 
            this.ICLabel.AutoSize = true;
            this.ICLabel.Location = new System.Drawing.Point(18, 11);
            this.ICLabel.Name = "ICLabel";
            this.ICLabel.Size = new System.Drawing.Size(29, 13);
            this.ICLabel.TabIndex = 3;
            this.ICLabel.Text = "IC = ";
            // 
            // lettersChart
            // 
            chartArea3.Name = "ChartArea1";
            this.lettersChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.lettersChart.Legends.Add(legend3);
            this.lettersChart.Location = new System.Drawing.Point(6, 38);
            this.lettersChart.Name = "lettersChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "letters";
            this.lettersChart.Series.Add(series3);
            this.lettersChart.Size = new System.Drawing.Size(740, 250);
            this.lettersChart.TabIndex = 2;
            this.lettersChart.Text = "chart1";
            // 
            // shiftTab
            // 
            this.shiftTab.Controls.Add(this.shiftLeftButton);
            this.shiftTab.Controls.Add(this.shiftRightButton);
            this.shiftTab.Location = new System.Drawing.Point(4, 22);
            this.shiftTab.Name = "shiftTab";
            this.shiftTab.Padding = new System.Windows.Forms.Padding(3);
            this.shiftTab.Size = new System.Drawing.Size(756, 362);
            this.shiftTab.TabIndex = 0;
            this.shiftTab.Text = "shift cipher";
            this.shiftTab.UseVisualStyleBackColor = true;
            // 
            // shiftLeftButton
            // 
            this.shiftLeftButton.Location = new System.Drawing.Point(112, 6);
            this.shiftLeftButton.Name = "shiftLeftButton";
            this.shiftLeftButton.Size = new System.Drawing.Size(100, 31);
            this.shiftLeftButton.TabIndex = 1;
            this.shiftLeftButton.Text = "Shift Left";
            this.shiftLeftButton.UseVisualStyleBackColor = true;
            this.shiftLeftButton.Click += new System.EventHandler(this.ShiftLeftButton_Click);
            // 
            // shiftRightButton
            // 
            this.shiftRightButton.Location = new System.Drawing.Point(6, 6);
            this.shiftRightButton.Name = "shiftRightButton";
            this.shiftRightButton.Size = new System.Drawing.Size(100, 31);
            this.shiftRightButton.TabIndex = 0;
            this.shiftRightButton.Text = "Shift Right";
            this.shiftRightButton.UseVisualStyleBackColor = true;
            this.shiftRightButton.Click += new System.EventHandler(this.ShiftRightButton_Click);
            // 
            // onepad
            // 
            this.onepad.Controls.Add(this.labelFrequancyLabel);
            this.onepad.Controls.Add(this.letterSwapLabel);
            this.onepad.Controls.Add(this.button1);
            this.onepad.Controls.Add(this.label3);
            this.onepad.Controls.Add(this.textBox2);
            this.onepad.Controls.Add(this.textBox1);
            this.onepad.Controls.Add(this.onePadOneButton);
            this.onepad.Location = new System.Drawing.Point(4, 22);
            this.onepad.Name = "onepad";
            this.onepad.Size = new System.Drawing.Size(756, 362);
            this.onepad.TabIndex = 4;
            this.onepad.Text = "one pad";
            this.onepad.UseVisualStyleBackColor = true;
            // 
            // labelFrequancyLabel
            // 
            this.labelFrequancyLabel.AutoSize = true;
            this.labelFrequancyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequancyLabel.Location = new System.Drawing.Point(257, 18);
            this.labelFrequancyLabel.Name = "labelFrequancyLabel";
            this.labelFrequancyLabel.Size = new System.Drawing.Size(0, 12);
            this.labelFrequancyLabel.TabIndex = 6;
            // 
            // letterSwapLabel
            // 
            this.letterSwapLabel.AutoSize = true;
            this.letterSwapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterSwapLabel.Location = new System.Drawing.Point(459, 18);
            this.letterSwapLabel.Name = "letterSwapLabel";
            this.letterSwapLabel.Size = new System.Drawing.Size(0, 16);
            this.letterSwapLabel.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Replace letters manually";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "=>";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 1;
            // 
            // onePadOneButton
            // 
            this.onePadOneButton.Location = new System.Drawing.Point(10, 12);
            this.onePadOneButton.Name = "onePadOneButton";
            this.onePadOneButton.Size = new System.Drawing.Size(163, 28);
            this.onePadOneButton.TabIndex = 0;
            this.onePadOneButton.Text = "Replace letters by frequency";
            this.onePadOneButton.UseVisualStyleBackColor = true;
            this.onePadOneButton.Click += new System.EventHandler(this.OnePadOneButton_Click);
            // 
            // affineTab
            // 
            this.affineTab.Location = new System.Drawing.Point(4, 22);
            this.affineTab.Name = "affineTab";
            this.affineTab.Padding = new System.Windows.Forms.Padding(3);
            this.affineTab.Size = new System.Drawing.Size(756, 362);
            this.affineTab.TabIndex = 1;
            this.affineTab.Text = "affine cipher";
            this.affineTab.UseVisualStyleBackColor = true;
            // 
            // vigenereTab
            // 
            this.vigenereTab.Controls.Add(this.encryptionKeyLabel);
            this.vigenereTab.Controls.Add(this.decryptionKeyLabel);
            this.vigenereTab.Controls.Add(this.decreaseLastWord);
            this.vigenereTab.Controls.Add(this.increaseLastWord);
            this.vigenereTab.Controls.Add(this.addCharToKey);
            this.vigenereTab.Controls.Add(this.label5);
            this.vigenereTab.Controls.Add(this.possibleKeyCharcters);
            this.vigenereTab.Controls.Add(this.calculateICforVigenereKeyButton);
            this.vigenereTab.Controls.Add(this.possibleKeyCount);
            this.vigenereTab.Controls.Add(this.currentVigenereStep);
            this.vigenereTab.Controls.Add(this.tryVigenereKeyButton);
            this.vigenereTab.Controls.Add(this.label6);
            this.vigenereTab.Controls.Add(this.decryptionKeyTextBox);
            this.vigenereTab.Controls.Add(this.replacePatternButton);
            this.vigenereTab.Controls.Add(this.label4);
            this.vigenereTab.Controls.Add(this.newPatternTextBox);
            this.vigenereTab.Controls.Add(this.oldPatternTextBox);
            this.vigenereTab.Location = new System.Drawing.Point(4, 22);
            this.vigenereTab.Name = "vigenereTab";
            this.vigenereTab.Size = new System.Drawing.Size(756, 362);
            this.vigenereTab.TabIndex = 2;
            this.vigenereTab.Text = "Vigenere cipher";
            this.vigenereTab.UseVisualStyleBackColor = true;
            // 
            // decreaseLastWord
            // 
            this.decreaseLastWord.Location = new System.Drawing.Point(259, 118);
            this.decreaseLastWord.Name = "decreaseLastWord";
            this.decreaseLastWord.Size = new System.Drawing.Size(115, 22);
            this.decreaseLastWord.TabIndex = 17;
            this.decreaseLastWord.Text = "Decrease Last Word";
            this.decreaseLastWord.UseVisualStyleBackColor = true;
            this.decreaseLastWord.Click += new System.EventHandler(this.DecreaseLastWord_Click);
            // 
            // increaseLastWord
            // 
            this.increaseLastWord.Location = new System.Drawing.Point(259, 90);
            this.increaseLastWord.Name = "increaseLastWord";
            this.increaseLastWord.Size = new System.Drawing.Size(115, 22);
            this.increaseLastWord.TabIndex = 16;
            this.increaseLastWord.Text = "Increase Last Word";
            this.increaseLastWord.UseVisualStyleBackColor = true;
            this.increaseLastWord.Click += new System.EventHandler(this.IncreaseLastWord_Click);
            // 
            // addCharToKey
            // 
            this.addCharToKey.Location = new System.Drawing.Point(178, 104);
            this.addCharToKey.Name = "addCharToKey";
            this.addCharToKey.Size = new System.Drawing.Size(75, 22);
            this.addCharToKey.TabIndex = 15;
            this.addCharToKey.Text = "Add Word";
            this.addCharToKey.UseVisualStyleBackColor = true;
            this.addCharToKey.Click += new System.EventHandler(this.AddCharToKey_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Possible key size";
            // 
            // possibleKeyCharcters
            // 
            this.possibleKeyCharcters.AutoSize = true;
            this.possibleKeyCharcters.Location = new System.Drawing.Point(11, 192);
            this.possibleKeyCharcters.Name = "possibleKeyCharcters";
            this.possibleKeyCharcters.Size = new System.Drawing.Size(0, 13);
            this.possibleKeyCharcters.TabIndex = 13;
            // 
            // calculateICforVigenereKeyButton
            // 
            this.calculateICforVigenereKeyButton.Location = new System.Drawing.Point(85, 156);
            this.calculateICforVigenereKeyButton.Name = "calculateICforVigenereKeyButton";
            this.calculateICforVigenereKeyButton.Size = new System.Drawing.Size(168, 23);
            this.calculateICforVigenereKeyButton.TabIndex = 12;
            this.calculateICforVigenereKeyButton.Text = "Look for possible IC characters";
            this.calculateICforVigenereKeyButton.UseVisualStyleBackColor = true;
            this.calculateICforVigenereKeyButton.Click += new System.EventHandler(this.VigenereICKeySearchButton_Click);
            // 
            // possibleKeyCount
            // 
            this.possibleKeyCount.Location = new System.Drawing.Point(6, 158);
            this.possibleKeyCount.Name = "possibleKeyCount";
            this.possibleKeyCount.Size = new System.Drawing.Size(62, 20);
            this.possibleKeyCount.TabIndex = 11;
            // 
            // currentVigenereStep
            // 
            this.currentVigenereStep.AutoSize = true;
            this.currentVigenereStep.Location = new System.Drawing.Point(396, 28);
            this.currentVigenereStep.Name = "currentVigenereStep";
            this.currentVigenereStep.Size = new System.Drawing.Size(0, 13);
            this.currentVigenereStep.TabIndex = 9;
            // 
            // tryVigenereKeyButton
            // 
            this.tryVigenereKeyButton.Location = new System.Drawing.Point(112, 104);
            this.tryVigenereKeyButton.Name = "tryVigenereKeyButton";
            this.tryVigenereKeyButton.Size = new System.Drawing.Size(60, 23);
            this.tryVigenereKeyButton.TabIndex = 8;
            this.tryVigenereKeyButton.Text = "Try Key";
            this.tryVigenereKeyButton.UseVisualStyleBackColor = true;
            this.tryVigenereKeyButton.Click += new System.EventHandler(this.TryVigenereKeyButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decryption key:";
            // 
            // decryptionKeyTextBox
            // 
            this.decryptionKeyTextBox.Location = new System.Drawing.Point(6, 106);
            this.decryptionKeyTextBox.Name = "decryptionKeyTextBox";
            this.decryptionKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.decryptionKeyTextBox.TabIndex = 6;
            // 
            // replacePatternButton
            // 
            this.replacePatternButton.Location = new System.Drawing.Point(109, 28);
            this.replacePatternButton.Name = "replacePatternButton";
            this.replacePatternButton.Size = new System.Drawing.Size(75, 25);
            this.replacePatternButton.TabIndex = 3;
            this.replacePatternButton.Text = "Replace";
            this.replacePatternButton.UseVisualStyleBackColor = true;
            this.replacePatternButton.Click += new System.EventHandler(this.ReplacePatternButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pattern";
            // 
            // newPatternTextBox
            // 
            this.newPatternTextBox.Location = new System.Drawing.Point(199, 32);
            this.newPatternTextBox.Name = "newPatternTextBox";
            this.newPatternTextBox.Size = new System.Drawing.Size(87, 20);
            this.newPatternTextBox.TabIndex = 1;
            // 
            // oldPatternTextBox
            // 
            this.oldPatternTextBox.Location = new System.Drawing.Point(6, 31);
            this.oldPatternTextBox.Name = "oldPatternTextBox";
            this.oldPatternTextBox.Size = new System.Drawing.Size(87, 20);
            this.oldPatternTextBox.TabIndex = 0;
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(6, 38);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(367, 152);
            this.cipherText.TabIndex = 1;
            this.cipherText.Text = "";
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(392, 38);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(360, 152);
            this.plainText.TabIndex = 2;
            this.plainText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cipher Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plain Text";
            // 
            // clearCipherText
            // 
            this.clearCipherText.Location = new System.Drawing.Point(287, 9);
            this.clearCipherText.Name = "clearCipherText";
            this.clearCipherText.Size = new System.Drawing.Size(86, 23);
            this.clearCipherText.TabIndex = 5;
            this.clearCipherText.Text = "Clear";
            this.clearCipherText.UseVisualStyleBackColor = true;
            this.clearCipherText.Click += new System.EventHandler(this.ClearCipherText_Click);
            // 
            // decryptionKeyLabel
            // 
            this.decryptionKeyLabel.AutoSize = true;
            this.decryptionKeyLabel.Location = new System.Drawing.Point(440, 251);
            this.decryptionKeyLabel.Name = "decryptionKeyLabel";
            this.decryptionKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.decryptionKeyLabel.TabIndex = 18;
            // 
            // encryptionKeyLabel
            // 
            this.encryptionKeyLabel.AutoSize = true;
            this.encryptionKeyLabel.Location = new System.Drawing.Point(440, 305);
            this.encryptionKeyLabel.Name = "encryptionKeyLabel";
            this.encryptionKeyLabel.Size = new System.Drawing.Size(0, 13);
            this.encryptionKeyLabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 584);
            this.Controls.Add(this.clearCipherText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.ciphers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ciphers.ResumeLayout(false);
            this.basicInfo.ResumeLayout(false);
            this.basicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lettersChart)).EndInit();
            this.shiftTab.ResumeLayout(false);
            this.onepad.ResumeLayout(false);
            this.onepad.PerformLayout();
            this.vigenereTab.ResumeLayout(false);
            this.vigenereTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl ciphers;
        private TabPage shiftTab;
        private TabPage affineTab;
        private TabPage vigenereTab;
        private RichTextBox cipherText;
        private RichTextBox plainText;
        private Label label1;
        private Button shiftLeftButton;
        private Button shiftRightButton;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart lettersChart;
        private TabPage basicInfo;
        private Label ICValue;
        private Label ICLabel;
        private Button addEngLetters;
        private Button removeENGCharacters;
        private Button clearCipherText;
        private TabPage onepad;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button onePadOneButton;
        private Label letterMapLabel;
        private Label letterSwapLabel;
        private Label labelFrequancyLabel;
        private Button replacePatternButton;
        private Label label4;
        private TextBox newPatternTextBox;
        private TextBox oldPatternTextBox;
        private Button tryVigenereKeyButton;
        private Label label6;
        private TextBox decryptionKeyTextBox;
        private Label currentVigenereStep;
        private Button calculateICforVigenereKeyButton;
        private TextBox possibleKeyCount;
        private Label possibleKeyCharcters;
        private Label label5;
        private Button increaseLastWord;
        private Button addCharToKey;
        private Button decreaseLastWord;
        private Label encryptionKeyLabel;
        private Label decryptionKeyLabel;
    }
}

