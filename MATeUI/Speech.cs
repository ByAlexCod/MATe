using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace MATeUI
{
    public partial class Speech : UserControl
    {
        public Speech()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine recon = new SpeechRecognitionEngine();
        SpeechSynthesizer synt = new SpeechSynthesizer();
        PromptBuilder blder = new PromptBuilder();



        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Choices list = new Choices();
            list.Add(new string[] { "close now ", "comment tu tappelle" });
            Grammar gr = new Grammar(new GrammarBuilder(list));


            try
            {
                recon.RequestRecognizerUpdate();
                recon.LoadGrammar(gr);
                recon.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recon_SpeechRecognized);
                recon.SetInputToDefaultAudioDevice();
                recon.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception)
            {


            }
        }

        void recon_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "close now")
            {
                blder.ClearContent();
                blder.AppendText("ok Sirina");
                synt.Speak(blder);
                //this.Close();

            }
            else if (e.Result.Text == "comment tu tappelle")
            {
                blder.ClearContent();
                blder.AppendText("je mappelle sirina");
                synt.Speak(blder);

            }
        }


    }
}
