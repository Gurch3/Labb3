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
    public partial class practiceForm : Form
    {
        private WordList practiceList;
        private int totalCount = 0;
        private int correctCount = 0;
        private string testResult;
        public practiceForm(WordList wordList)
        {
            practiceList = wordList;
            
            InitializeComponent();
            PracticeWord(practiceList);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PracticeWord(WordList practiceList)
        {
            Word practiceWord = practiceList.GetWordToPractice();   
            int from = practiceWord.FromLanguage;
            int to = practiceWord.ToLanguage;
            labelTranslate.Text = labelTranslate.Text + " " + practiceWord.Translations[from] + " to language: " + practiceList.Languages[to];
            testResult = practiceWord.Translations[to];

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxAnswer.Text == testResult)
            {
                correctCount++;
                totalCount++;
                string message = "Answer was correct";
                MessageBox.Show(message);
            }
            else
            {
                string message = "Answer was wrong";
                MessageBox.Show(message);
                totalCount++;
            }
            labelGuesses.Text = "You have answered:" + totalCount.ToString() + " in total and answered " + correctCount.ToString() + " Correctly";
            labelTranslate.Text = "Traslate: ";
            PracticeWord(practiceList);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void practiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
