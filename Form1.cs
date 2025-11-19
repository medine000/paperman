using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        string file = "data.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                richTextBox1.Text = File.ReadAllText(file);
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox("Enter text to append:", "Append Text", "");
            if (text == " ")
                return;


            File.AppendAllText(file, text + "\n");

            MessageBox.Show("Yazıldı!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
                richTextBox1.Clear();
                MessageBox.Show("Fayl silindi.");
            }
            else
            {
                MessageBox.Show("Silinəcək fayl yoxdur.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!File.Exists(file))
            {
                MessageBox.Show("Fayl yoxdur.");
                return;
            }

            string text = File.ReadAllText(file);

            
            string[] words = text.Split(' ');

            int say = words.Length;

            MessageBox.Show("Sözlərin sayı: " + say);
        }
    }
    }

