using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt|Файл RTF|*.rtf";
            saveFileDialog1.Filter = "Текстовый файл (*.txt)|*.txt|Файл RTF|*.rtf";
            openFileDialog2.Filter = " (*.png)|*.png|(*.jpeg)|*.jpeg|(*.jpg)|*.jpg";
            richTextBox1.EnableAutoDragDrop = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string type = filename.Substring(filename.LastIndexOf('.') + 1);
            if (type == "rtf")
            {
                string fileText = File.ReadAllText(filename);
                richTextBox1.Rtf = fileText;
                MessageBox.Show("Файл открыт!");
            }
            else if (type == "txt")
            {
                string fileText = File.ReadAllText(filename);
                richTextBox1.Text = fileText;
                MessageBox.Show("Файл открыт!");
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string type = filename.Substring(filename.LastIndexOf('.') + 1);
            if (type == "rtf")
            {
                File.WriteAllText(filename, richTextBox1.Rtf);
                MessageBox.Show("Файл сохранен!");
            }
            else if (type == "txt")
            {
                File.WriteAllText(filename, richTextBox1.Text);
                MessageBox.Show("Файл сохранен!");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string type = filename.Substring(filename.LastIndexOf('.') + 1);
            if (type == "rtf")
            {
                File.WriteAllText(filename, richTextBox1.Rtf);
                MessageBox.Show("Файл сохранен!");
            }
            else if (type == "txt")
            {
                File.WriteAllText(filename, richTextBox1.Text);
                MessageBox.Show("Файл сохранен!");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void настройкаШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void настройкиФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                richTextBox1.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void выделитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectAll();
            }
        }

        private void изменитьШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void изменитьЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                colorDialog2.ShowDialog();
                richTextBox1.SelectionColor = colorDialog2.Color;
            }
        }

        private void настройкаЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                colorDialog2.ShowDialog();
                richTextBox1.SelectionColor = colorDialog2.Color;
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Старовойтов Максим\nВерсия приложения 0.0.1\n__________________\nAuthor: Maxim Starovoitov\nApplication version 0.0.1");
        }

        private void цветВыделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                colorDialog3.ShowDialog();
                richTextBox1.SelectionBackColor = colorDialog3.Color;
            }
        }

        private void цветВыделенияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                colorDialog3.ShowDialog();
                richTextBox1.SelectionColor = colorDialog3.Color;
            }
        }

        private void вставкаИзображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            string filename2 = openFileDialog2.FileName;
            Image img = Image.FromFile(filename2);
            Clipboard.Clear();
            Clipboard.SetImage(img);
            richTextBox1.Paste();
            Clipboard.Clear();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search SearchForm = new search();
            SearchForm.Owner = this;
            SearchForm.Show();
        }

        private void удалитьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionBackColor = Color.White;
            }
        }

        private void найтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            search SearchForm = new search();
            SearchForm.Owner = this;
            SearchForm.Show();
        }

        private void удалитьВыделениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.SelectionBackColor = Color.White;
            }
        }

    }
}
