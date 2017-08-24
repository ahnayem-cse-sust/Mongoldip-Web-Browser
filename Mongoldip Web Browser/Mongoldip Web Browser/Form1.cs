using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.IO;

namespace Mongoldip_Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }

        String full_html_text;

        private void urlButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(urlBox.Text);
            String demoText = urlBox.Text + " is loading.";
            say(demoText);
            HtmlDocument htmlDoc = webBrowser1.Document;
            HtmlElementCollection col = null;
            try
            {
               col  = htmlDoc.GetElementsByTagName("a");
            }
            catch
            {
                MessageBox.Show("Link searching Error");
            }

            foreach (HtmlElement element in col)
            {
                string link;

                link = element.GetAttribute("href");
                Console.Write(link);
                if (link == null || link.Length == 0)
                {
                    Console.Write("No link");
                }
            }
            
            
        }

        private void go_url(object sender, KeyPressEventArgs e)
        {
           
        }

        SpeechSynthesizer sSynth;
        // PromptBuilder pBuilder = new PromptBuilder();
        // SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        public void say(String toSay)
        {
           // pBuilder.ClearContent();
           // pBuilder.AppendText(toSay);
            sSynth = new SpeechSynthesizer();
            try
            {
                sSynth.SpeakAsync(toSay);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occured");
            }
        }

        private void load(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                urlButton_Click(this, e);
            }
        }

        private void formKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("This is Esc");
                try
                {
                    sSynth.Dispose();
                }
                catch(Exception ex)
                {
                    
                }
            }
        }

        
    }
}
