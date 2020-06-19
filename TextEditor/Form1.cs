using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          }

       

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
            

        }
        // дейтсвия при нажатии кнопки "открыть" 
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // окно открытия файла и запись текста из выбранного файла в текстовое поле
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
                try { richTextBox1.LoadFile(OFD.FileName); }
                catch
                {
                    MessageBox.Show("Error");
                }
            richTextBox1.ReadOnly = false;


        }
        //  дейтсвия при нажатии кнопки "сохранить" 
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // окно сохранения файла и запись из текстового поля в выбранный файл
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "txt files (*.rtf;*.txt)|*.rtf;*.txt|All files (*.*)|*.*";
            SFD.ShowDialog();
            if (SFD.FileName == String.Empty) return;
            try
            {
                richTextBox1.SaveFile(SFD.FileName);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        // дейтсвия при нажатии кнопки "выйти" 
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //выход из редактора
            Close();
        }

        //  дейтсвия при нажатии кнопки "просмотретть файл" 
        private void просмотретьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // окно открытия файла и запись выбранного файла в текстовое поле
           
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
                try { richTextBox1.LoadFile(OFD.FileName); }
                catch
                {
                    MessageBox.Show("Error");
                }
            // запрет на изменение файла
            richTextBox1.ReadOnly = true;


        }




        // дейтсвия при нажатии кнопки "выравнить по левому краю"
        private void left_Click(object sender, EventArgs e)
        {
            // сдвиг текста в текстовом поле richtextbox1 к левому краю
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }


        //  дейтсвия при нажатии кнопки "выравнить по правому краю"
        private void right_Click(object sender, EventArgs e)
        {
            // сдвиг текста в текстовом поле richtextbox1 к правому краю
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        // дейтсвия при нажатии кнопки "выравнить по ширине краю"
        private void center_Click(object sender, EventArgs e)
        {
            // сдвиг текста в текстовом поле richtextbox1 к середине 
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }


        //  дейтсвия при нажатии кнопки "сделать текст жирным" 
        private void сделатьТекстЖирнымToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение шрифта текста на жирный 
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        //  дейтсвия при нажатии кнопки "выделить текст курисвом" 
        private void выделитьТекстКурсивомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение шрифта текста курсивный
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic);
        }
        //  дейтсвия при нажатии кнопки "подчекрнуть текст" 
        private void подчеркнутьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение шрифта текста на подчеркнутый
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Underline);  
        }

        //  дейтсвия при нажатии кнопки "стандартный шрифт" 
        private void стандартныйШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение шрифта текста на стандартный
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }
        //  дейтсвия при нажатии кнопки "красный текст" 
        private void красныйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение цвета текста на красный
            richTextBox1.SelectionColor = Color.Red;
        }
        // дейтсвия при нажатии кнопки "зеленый текст" 
        private void зеленыйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение цвета текста на зеленый
            richTextBox1.SelectionColor = Color.Green;
        }

        private void синийТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение цвета текста на синий
            richTextBox1.SelectionColor = Color.Blue;
        }
        //  дейтсвия при нажатии кнопки "стандартный цвет текста" 
        private void стандартныйЦветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // изменение цвета текста на стандартный черный
            richTextBox1.SelectionColor = Color.Black;
        }
        //  дейтсвия при нажатии кнопки "черный фон" 
        private void черныйФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // смена на черный фон и автоматическое изменение текста на белый цвет
            richTextBox1.BackColor = Color.Black;
            richTextBox1.SelectionColor = Color.White;
        }
        //  дейтсвия при нажатии кнопки"серый фон" 
        private void серыйФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // смена на серый фон и автоматическое изменение текста на белый цвет
            richTextBox1.BackColor = Color.Gray;
            richTextBox1.SelectionColor = Color.White;

        }
        //  дейтсвия при нажатии кнопки "белый фон" 
        private void белыйФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // смена на белый фон и автоматическое изменение текста на черный цвет
            richTextBox1.BackColor = Color.White;
            richTextBox1.SelectionColor = Color.Black;
        }
    }
}
