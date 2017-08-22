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
            
            say("You should Filish");
            full_html_text = webBrowser1.DocumentText;
            
        }

        private void go_url(object sender, KeyPressEventArgs e)
        {
           
        }

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        public void say(String toSay)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(toSay);
            sSynth.Speak(pBuilder);
        }

        private void load(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                urlButton_Click(this, e);
            }
        }

        
    }
}
