using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;
using System.Speech.Synthesis;

namespace SharpBrowser
{
    public partial class TextForm : Form
    {

        public TextForm(string url)
        {
            InitializeComponent();
            TextForm_Load(url);
        }

        private void TextForm_Load( string urlPath)
        {
            //Create the WebBrowser control
            WebBrowser wb = new WebBrowser();
            //Add a new event to process document when download is completed   
            wb.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(DisplayText);
            //Download the webpage
            wb.Url = new System.Uri(urlPath);
        }

        SpeechSynthesizer sSynth;
        // PromptBuilder pBuilder = new PromptBuilder();
        // SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();

        public void Speak(String toSay)
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

        public void stopSpeak()
        {
            try
            {
                sSynth.Dispose();
            }
            catch (Exception ex)
            {

            }
        }
        private void key_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                
                string s = richTextBox1.SelectedText;
               
                stopSpeak();
                Speak(s);
            }
            else if (e.KeyCode == Keys.F10)
            {

                string s = richTextBox1.Text;
                
                stopSpeak();
                Speak(s);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                stopSpeak();
                this.Close();
            }
        }

        private void DisplayText(object sender, WebBrowserDocumentCompletedEventArgs e)
        {   //Create the WebBrowser control and IHTMLDocument2
            WebBrowser wb = (WebBrowser)sender;
            IHTMLDocument2 htmlDocument =
            wb.Document.DomDocument as IHTMLDocument2;
            //Select all the text on the page and create a selection object
            wb.Document.ExecCommand("SelectAll", false, null);
            IHTMLSelectionObject currentSelection = htmlDocument.selection;
            //Create a text range and send the range’s text to your text box
            IHTMLTxtRange range = currentSelection.createRange() as IHTMLTxtRange;
            richTextBox1.Text = range.text;
        }
    }
}
