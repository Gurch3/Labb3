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
    public partial class sortForm : Form
    {
        private WordList sortList;
        public sortForm(WordList wordList)
        {
            InitializeComponent();
            sortList = wordList;
            LabelListLang(sortList);
        }

        private string LabelListLang(WordList sortList)
        {
            //foreach (string lang in sortList.Languages)
            //{
            //    labelListLanguages.Text = labelListLanguages.Text + " " + lang;

        //}
            for (int i = 0; i<sortList.Languages.Length; i++)
            {
                labelListLanguages.Text = labelListLanguages.Text + " " + i + "." + sortList.Languages[i];

            }

            return labelListLanguages.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int lang = ((int)numericUpDownLanguage.Value);
            sortList.List(lang, PrintTranslations);
            sortList.Save();

        }

        void PrintTranslations(string[] translations)
        {
            
            foreach (string word in translations)
            {
                textBox1.Text = textBox1.Text + " " + word;
                textBox1.Text.Trim();

            }
            textBox1.Text += Environment.NewLine;
            
        }
    }
}
