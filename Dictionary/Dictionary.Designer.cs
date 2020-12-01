namespace Dictionary
{
    partial class Dictionary
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbTranslatedWord = new System.Windows.Forms.TextBox();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btnDeToEn = new System.Windows.Forms.Button();
            this.btnDeToDialekt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lBoxLetters = new System.Windows.Forms.ListBox();
            this.resetLetterSelection = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(503, 310);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(266, 22);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbTranslatedWord
            // 
            this.tbTranslatedWord.Location = new System.Drawing.Point(503, 353);
            this.tbTranslatedWord.Name = "tbTranslatedWord";
            this.tbTranslatedWord.Size = new System.Drawing.Size(266, 22);
            this.tbTranslatedWord.TabIndex = 2;
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 16;
            this.lBoxGermanWords.Location = new System.Drawing.Point(119, 74);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(266, 356);
            this.lBoxGermanWords.TabIndex = 8;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(403, 74);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(266, 22);
            this.tbTranslation.TabIndex = 9;
            // 
            // btnDeToEn
            // 
            this.btnDeToEn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeToEn.Location = new System.Drawing.Point(663, 397);
            this.btnDeToEn.Name = "btnDeToEn";
            this.btnDeToEn.Size = new System.Drawing.Size(106, 33);
            this.btnDeToEn.TabIndex = 3;
            this.btnDeToEn.Text = "Englisch";
            this.btnDeToEn.UseVisualStyleBackColor = true;
            this.btnDeToEn.Click += new System.EventHandler(this.btnDeToEn_Click);
            // 
            // btnDeToDialekt
            // 
            this.btnDeToDialekt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeToDialekt.Location = new System.Drawing.Point(503, 397);
            this.btnDeToDialekt.Name = "btnDeToDialekt";
            this.btnDeToDialekt.Size = new System.Drawing.Size(106, 33);
            this.btnDeToDialekt.TabIndex = 4;
            this.btnDeToDialekt.Text = "Dialekt";
            this.btnDeToDialekt.UseVisualStyleBackColor = true;
            this.btnDeToDialekt.Click += new System.EventHandler(this.btnDeToDialekt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Deutsch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Übersetzung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Deutsch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Übersetzung";
            // 
            // lBoxLetters
            // 
            this.lBoxLetters.FormattingEnabled = true;
            this.lBoxLetters.ItemHeight = 16;
            this.lBoxLetters.Location = new System.Drawing.Point(50, 74);
            this.lBoxLetters.Name = "lBoxLetters";
            this.lBoxLetters.Size = new System.Drawing.Size(63, 356);
            this.lBoxLetters.TabIndex = 7;
            this.lBoxLetters.SelectedIndexChanged += new System.EventHandler(this.lBoxLetters_SelectedIndexChanged);
            // 
            // resetLetterSelection
            // 
            this.resetLetterSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetLetterSelection.Location = new System.Drawing.Point(50, 28);
            this.resetLetterSelection.Name = "resetLetterSelection";
            this.resetLetterSelection.Size = new System.Drawing.Size(63, 23);
            this.resetLetterSelection.TabIndex = 5;
            this.resetLetterSelection.Text = "Alle";
            this.resetLetterSelection.UseVisualStyleBackColor = true;
            this.resetLetterSelection.Click += new System.EventHandler(this.resetLetterSelection_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(120, 29);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 22);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Suchen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(498, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Neues Wort";
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.resetLetterSelection);
            this.Controls.Add(this.lBoxLetters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeToDialekt);
            this.Controls.Add(this.btnDeToEn);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.tbTranslatedWord);
            this.Controls.Add(this.tbGermanWord);
            this.Name = "Dictionary";
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbTranslatedWord;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btnDeToEn;
        private System.Windows.Forms.Button btnDeToDialekt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lBoxLetters;
        private System.Windows.Forms.Button resetLetterSelection;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

