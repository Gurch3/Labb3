using System.Collections;
using System.Windows.Forms.VisualStyles;
using ClassLibrary1;
namespace WinFormsLabb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lists_Click(object sender, EventArgs e)
        {
            textBox1.Text = "All lists in directory: " + string.Join(", ", WordList.GetLists());
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            List<string> newList = textBox1.Text.Split(' ').ToList();
            string listName = newList[0];
            newList.RemoveAt(0);
            if (WordList.LoadList(listName) == null)
            {
                if (newList.Count > 1)
                {
                    new WordList(listName, newList.ToArray());
                    WordList addNew = WordList.LoadList(listName);
                    new AddWordsForm(addNew).Show();
                }
            }
            else textBox1.Text = "List already exists";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string list = textBox1.Text;
            if (WordList.LoadList(list) != null)
            {
                WordList addWordsToList = WordList.LoadList(list);
                new AddWordsForm(addWordsToList).Show();
               
            }
        }

        private void buttonRemoveWord_Click(object sender, EventArgs e)
        {
            string list = textBox1.Text;
            if (WordList.LoadList(list) != null)
            {
                WordList removeWordsFromList = WordList.LoadList(list);
                new RemoveWordsForm(removeWordsFromList).Show();

            }

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            string list = textBox1.Text;
            if(WordList.LoadList(list) != null)
            {
                WordList count = WordList.LoadList(list);
                string message = count.Count().ToString();
                MessageBox.Show(message);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string list = textBox1.Text;
            if (WordList.LoadList(list) != null)
            {
                WordList sortList = WordList.LoadList(list);
                new sortForm(sortList).Show();

            }

        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            string list = textBox1.Text;
            if (WordList.LoadList(list) != null)
            {
                WordList practice = WordList.LoadList(list);
                new practiceForm(practice).Show();

            }
        }
    }
}