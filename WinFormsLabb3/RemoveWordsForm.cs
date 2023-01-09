using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLabb3
{
    public partial class RemoveWordsForm : Form
    {
        private WordList removeWords;
        public RemoveWordsForm(WordList wordList)
        {
            removeWords = wordList;
            InitializeComponent();
            labelListLanguages.Text = labelListLanguages.Text + " " + removeWords.Name + " with languages: ";
            labelListLang(removeWords);
        
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int lang = ((int)numericupdownLanguage.Value);
            string word = textBoxWord.Text;
            if (removeWords.Remove(lang, word) == true)
            {
                string message = "Word Removed";
                MessageBox.Show(message);
                removeWords.Save();
            }
            else
            {
                string message = "Something went wrong, try again";
                MessageBox.Show(message);
            }

        }
        private string labelListLang(WordList removeWords)
        {

            for (int i = 0; i < removeWords.Languages.Length ; i++)
            {
                labelListLanguages.Text = labelListLanguages.Text + " " + i + "." + removeWords.Languages[i];

            }

            return labelListLanguages.Text;
        }
    }
}
