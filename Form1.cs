using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using NLog;



namespace QRCODETESTAPP
{
    public partial class Form1 : Form
    {
        public string path;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.OptionWriteEmptyNodes = true;
            doc.LoadHtml(path);
            doc.Load(path);
            


            var node = doc.DocumentNode.SelectSingleNode("//html");

        }

        private void headmevcut_Click(object sender, EventArgs e)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.OptionWriteEmptyNodes = true;
            doc.LoadHtml(path);
            doc.Load(path);

            var node = doc.DocumentNode.SelectSingleNode("//head");


            richTextBox1.Text = node.OuterHtml;
        }

        public void headbutton_Click(object sender, EventArgs e)
        {
            string html = File.ReadAllText(Path.GetFullPath(path), Encoding.UTF8);
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.OptionWriteEmptyNodes = true;
            doc.LoadHtml(html);  
            doc.DocumentNode.SelectSingleNode("//head").AppendChild(HtmlNode.CreateNode(File.ReadAllText(Path.GetFullPath("Include/FaturaHead.txt"))));
            var node = doc.DocumentNode.SelectSingleNode("//head");
            

            richTextBox1.Text = node.OuterHtml;
          
        }

        private void bodybutton_Click(object sender, EventArgs e)
        {
            
            var doc = new HtmlAgilityPack.HtmlDocument();
            

            var node = doc.DocumentNode.SelectSingleNode("//body");


            richTextBox1.Text = node.OuterHtml;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Yapılan Değişiklik Geri Alınamaz.", "Emin Misiniz?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                string html = File.ReadAllText(Path.GetFullPath(path), Encoding.UTF8);
                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.OptionWriteEmptyNodes = true;
                htmlDoc.LoadHtml(html);
                if (CheckIfNodeExist() == true)
                {
                    MessageBox.Show("Zaten eklediniz.", "Kontrol", MessageBoxButtons.OK);
                    return;
                    
                    
                }
                else
                {
                    htmlDoc.DocumentNode.SelectSingleNode("//head").AppendChild(HtmlNode.CreateNode(File.ReadAllText(Path.GetFullPath("Include/FaturaHead.txt"))));
                    htmlDoc.Save(path);
                }
                
               
                bool CheckIfNodeExist()
                {
                    var node = htmlDoc.DocumentNode.SelectSingleNode("//head");
                    if (node.OuterHtml.Contains(File.ReadAllText(Path.GetFullPath("Include/FaturaHead.txt")))){

                        return true;
                        
                    }
                    else
                    {
                        return false;
                    }
                    
                }



            }
            catch (Exception ex)
            {
                LogManager.GetLogger("").Error(ex.Message);
            }
        }

       

    }
}
