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
            sortList = wordList;
            LabelListLang(sortList);
            InitializeComponent();
        }

        private string LabelListLang(WordList sortList)
        {

            for (int i = 0; i < sortList.Languages.Length; i++)
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
            string message = "Sorted list";
            foreach (string word in translations)
            {
                message = message + " , " + word;

            }
            MessageBox.Show(message);
        }
    }
}
