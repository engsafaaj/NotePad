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

namespace NotPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var di = new SaveFileDialog();
            di.Filter = "Text Files|*.txt";
            di.FileName = "Txt" + ".txt";
            var result = di.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(di.FileName, richTextBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var di = new OpenFileDialog();
            di.Filter = "Text Files|*.txt";
            di.FileName = "Txt" + ".txt";
            var result = di.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text= File.ReadAllText(di.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text =richTextBox1.Text+ Clipboard.GetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.Text);
                richTextBox1.Text = "";
            }
            catch
            {

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, new Point(100, 100));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var difo = new FontDialog();
            var rs = difo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                richTextBox1.Font = difo.Font;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.No;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var boco = new ColorDialog();
            var rs = boco.ShowDialog();
            if (rs == DialogResult.OK)
            {
                richTextBox1.BackColor = boco.Color;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var boco = new ColorDialog();
            var rs = boco.ShowDialog();
            if (rs == DialogResult.OK)
            {
                richTextBox1.ForeColor = boco.Color;
            }
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.ZoomFactor = bunifuSlider1.Value;

            }
            catch
            {

            }
        }
    }
}
