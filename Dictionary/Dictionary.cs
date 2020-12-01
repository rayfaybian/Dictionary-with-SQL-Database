using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DictLogic;
using DictionaryData;


namespace Dictionary
{
    public partial class Dictionary : Form
    {
        DictionaryController controller;
        

        public Dictionary()
        {
            InitializeComponent();
            controller = new DictionaryController();
            lBoxLetters.DataSource = controller.ImportAlphabet();
            UpdateRoutine();
        }

        private void UpdateRoutine()
        {
            lBoxGermanWords.DataSource = controller.UpdateTranslation();
            changeLabelText();
        }

        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxGermanWords.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord))
            {                 
                tbTranslation.Text = controller.GetTranslation(selectedWord);
            }
        }
               

        //Deutsch zu Englisch
        private void btnDeToEn_Click(object sender, EventArgs e)
         {
            var german = tbGermanWord.Text;
            var translation = tbTranslatedWord.Text;

            if (!string.IsNullOrEmpty(german) && !string.IsNullOrEmpty(translation))
            {
                controller.NewGermanWord(german, translation);
            }

            controller.SetCurrentLanguage("eng");
            UpdateRoutine();
            tbGermanWord.Text = "";
            tbTranslatedWord.Text = "";

        }

        //Deutsch zu Dialekt
        private void btnDeToDialekt_Click(object sender, EventArgs e)
        {
            var german = tbGermanWord.Text;
            var translation = tbTranslatedWord.Text;

            if (!string.IsNullOrEmpty(german) && !string.IsNullOrEmpty(translation))
            {
                controller.NewDialectWord(german, translation);
            }

            controller.SetCurrentLanguage("dia");
            UpdateRoutine();
            tbGermanWord.Text = "";
            tbTranslatedWord.Text = "";

        }

        

        private void lBoxLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = lBoxLetters.SelectedItem as string;

            if (!string.IsNullOrEmpty(selection))
            {
                lBoxGermanWords.DataSource = controller.SelectByLetter(selection);
            }
            else
            {
                UpdateRoutine();
            }
        }

        private void resetLetterSelection_Click(object sender, EventArgs e)
        {
            lBoxLetters.SelectedItem = null;
            controller.UpdateTranslation();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            lBoxGermanWords.DataSource = controller.GetSearchResults(tbSearch.Text);
        }

        private void changeLabelText()
        {
            if (controller.GetCurrentLanguage().Equals("eng"))
            {
                label4.Text = "Englisch";
            }
            else if (controller.GetCurrentLanguage().Equals("dia"))
            {
                label4.Text = "Dialekt";
            }
        }
    }
}
