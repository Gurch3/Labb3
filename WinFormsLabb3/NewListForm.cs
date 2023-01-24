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
    public partial class NewListForm : Form
    {
        private string _listName;
        public NewListForm(string listName)
        {
            _listName = listName;
  
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string[] languages = textBoxLanguages.Text.Split(',');
            foreach(string lang in languages)
            {
                lang.Trim();
            }
            new WordList(_listName, languages).Save();
            WordList addWordsToList = WordList.LoadList(_listName);
            new AddWordsForm(addWordsToList).Show();
            
            
        }
    }
}
