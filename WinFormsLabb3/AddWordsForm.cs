using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLabb3
{
    public partial class AddWordsForm : Form
    {
        private string listName;
        private WordList addWords;
        public AddWordsForm(WordList wordList)
        {
            InitializeComponent();
            addWords = wordList;
            labelLang(addWords);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            string[] words = textBoxWord.Text.Split(',').ToArray();
            
            if(words.Length == addWords.Languages.Length)
            {
                addWords.Add(words);
                addWords.Save();
                textBoxWord.Clear();
            }
            else
            {
                string message = "Wrong amount of translations";
                MessageBox.Show(message);
            }
            
        }

        private string labelLang(WordList addWords)
        {
            foreach(string lang in addWords.Languages)
            {
                labelLanguages.Text = labelLanguages.Text + " " + lang;
            }

            return labelLanguages.Text;
        }
       
     

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
