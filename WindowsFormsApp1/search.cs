using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class search : Form
    {
        TextEditor searchform;
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchform = (TextEditor)this.Owner;
            string[] words = textBox1.Text.Split(',');
            foreach(string word in words)
            {
                int startIndex = 0;
                while (startIndex < searchform.richTextBox1.TextLength)
                {
                    int wordStartIndex = searchform.richTextBox1.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        searchform.richTextBox1.SelectionStart = wordStartIndex;
                        searchform.richTextBox1.SelectionLength = word.Length;
                        searchform.richTextBox1.SelectionBackColor = Color.Yellow;
                    }
                    else
                        break;
                    startIndex += wordStartIndex + word.Length;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchform.richTextBox1.SelectionStart = 0;
            searchform.richTextBox1.SelectAll();
            searchform.richTextBox1.SelectionBackColor = Color.White;
        }
    }
}
