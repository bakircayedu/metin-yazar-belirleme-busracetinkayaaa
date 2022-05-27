using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace VeriYapilariÖdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack linkedList = new Stack();

        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "C:";
            file.Filter = "Text Dosyası: |*.txt";
            file.CheckFileExists = false;
            file.Title = "Text Dosyası Seçiniz";
            
            //  OpenFileDialog ekranı açıyor
            if (file.ShowDialog() == DialogResult.OK)
            {
                string filePath = file.FileName;
                txtBoxPath.Text = filePath;

                string readFile = System.IO.File.ReadAllText(filePath);
                richTxtBox.Text = readFile;
            }
        }

        Stack Swords;
        Stack Ssentences;
        private void btnSay_Click(object sender, EventArgs e)
        {
            Swords = new Stack();
            Ssentences = new Stack();

            string[] sentences = richTxtBox.Text.Split('.');
            string[] words = richTxtBox.Text.Split(' ');

            int wordCount = 0;
            int sentenceCount = sentences.Length;
            float kelimeOrt = 0;

            if (sentences.Length == 0)
            {
                sentenceCount = 1;
            }
            foreach (string word in words)
            {
               lstViewOzellik.Items.Add(word.Split(' ').Length + word);

               wordCount++;
            }

            foreach (string sentence in sentences)
            {
                lstViewOzellik.Items.Add(sentence.Split(' ').Length + sentence);
                sentenceCount++;
            }
            kelimeOrt = wordCount / sentenceCount;

            lstViewOzellik.Items.Add(wordCount.ToString() + sentences);
            lstViewOzellik.Items.Add(sentenceCount.ToString());
            lstViewOzellik.Items.Add(kelimeOrt.ToString());

            foreach (var item in sentences)
            {
                Ssentences.Push(item);
               

            }
            foreach (var item in words)
            {
                Swords.Push(item);
                lstViewOzellik.Items.Add(item);

            }
        }
        private void btnStackOku_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
