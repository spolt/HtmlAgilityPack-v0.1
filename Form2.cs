using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCODETESTAPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void EditorAc()
        {
            
            Form1 Xslteditor = new Form1(); 
            Xslteditor.path = richTextBox1.Text; 
            Xslteditor.Show();            
            this.Hide();

        }
        private void DosyaOku()
        {

            OpenFileDialog XsltFile = new OpenFileDialog();
            XsltFile.Filter = "(*.xslt)|*.xslt";
            if (XsltFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) ;
            {
                string path = XsltFile.FileName;

                richTextBox1.Text = path;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DosyaOku();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditorAc();
        }
    }
}
