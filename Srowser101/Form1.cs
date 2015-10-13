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
using System.Windows;



namespace Srowser101

{

  
    public partial class Form1 : Form
    
    {
        int achone = 0;
        int debog = 0;
        public Form1()

        {
           
            InitializeComponent();
            

           
       }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            achone = richTextBox1.Text.Length;
           
            
           if (richTextBox1.Text == "")
           {

               webBrowser1.DocumentText = textBox4.Text;
               
           }
          
            if (richTextBox1.Text.Length > 1)
            {
                
                for (int i = 1; i < 100; i++)
                {
                   
                    
                }
               
                webBrowser1.DocumentText = richTextBox1.Text;
                webBrowser1.Document.DomDocument.GetType().GetProperty("designMode").SetValue(webBrowser1.Document.DomDocument, "On", null);
                
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.SetAttribute("contenteditable", "true");
            //
           
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
               //Achievements
            if (achone == 10)
            {
                MessageBox.Show("Hey " + textBox1.Text + "You just earnt the achievement: SPELLING BEE!");
                Achievements.Items.Add("Spelling bee");
            }



























            button2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (webBrowser1.IsOffline)
            {
                linkLabel1.Text = "Offline, but still running";
            }
            else
            {
                linkLabel1.Text = "Online and good";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                

        
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = webBrowser1.Document.Body.InnerHtml;
         

                        
                     
                 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            debog = debog + 1;
            if (debog == 2)
            {
                MessageBox.Show("Hey " + textBox1.Text + "You just earnt the achievement: Pro Debogger!");
                Achievements.Items.Add("Debogger");
            }
            webBrowser1.Navigate(textBox2.Text);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            button2.Visible = !button2.Visible;
            if (textBox2.Text !="")
            {
                MessageBox.Show("Well, this is a nice creation, maybe you should work for " + textBox2.Text.Replace("http://www.", ""));
            }
            else
            {
                MessageBox.Show("Nice Project!");
            }

         
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = System.Drawing.Color.Red;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";

            
        }

        private void keepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keepies = richTextBox1.SelectedText;
            richTextBox1.Text = "";
            richTextBox1.Text = keepies;

            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void highlightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bluToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            webBrowser1.Width = 2000;
            webBrowser1.Height = 2000;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Text = label2.Text + textBox1.Text;
        }

       
    }
}
