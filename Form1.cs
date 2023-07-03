using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Speech.Recognition;

namespace Dismord_voic
{
    public partial class Form1 : Form
    {
        int Confidence = 60;
        CancellationTokenSource cancellationTokenSource;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            Application.SetSuspendState(PowerState.Hibernate, true, true);


        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            Confidence_trackBar.Value = Confidence;
            Confidence_label.Text = Convert.ToString(Confidence)+"%";

            


            Load_button_Click(sender, e);
            EXEOpenButton_Click(sender,e);

            await StartRecognition();


            

        }


        private async Task StartRecognition()
        {
            cancellationTokenSource= new CancellationTokenSource();
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("ru-Ru"));
            Grammar grammar = new Grammar("словарь.xml");

            sre.LoadGrammar(grammar);
            sre.SpeechRecognized += recogn;
            sre.SpeechRecognitionRejected += recogn_rejected;

            sre.SetInputToDefaultAudioDevice();
            sre.RecognizeAsync(RecognizeMode.Multiple);
            sre.MaxAlternates = 1;
            
            try
            {
                await Task.Delay(-1, cancellationTokenSource.Token);
            }
            catch (TaskCanceledException)
            {
                sre.RecognizeAsyncCancel();
            }
            
        }



        private void recogn(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence>= Confidence/100.0) {
                if (e.Result.Semantics.ContainsKey("start"))
                {
                    textBox1.Text ="Открыл: "+ e.Result.Semantics["start"].Value.ToString();
                    Process.Start(e.Result.Semantics["start"].Value.ToString());
                    
                }
                else if (e.Result.Semantics.ContainsKey("close"))
                {
                    textBox1.Text = "Закрыл: " + e.Result.Semantics["close"].Value.ToString();
                    Process[] process_list = Process.GetProcessesByName(e.Result.Semantics["close"].Value.ToString());
                    foreach (Process d_process in process_list)
                    {
                        d_process.Kill();
                    }
                }
                else if (e.Result.Semantics.ContainsKey("protocol"))
                {
                    if (e.Result.Semantics["protocol"].Value.ToString()== "blackout")
                    {
                        if (e.Result.Semantics["object"].Value.ToString() == "Морак")
                        {
                            Process.Start("shutdown", "/s /t 0");
                        }
                    }
                    else if (e.Result.Semantics["protocol"].Value.ToString() == "dota2")
                    {
                        StreamReader F = new StreamReader("Dota_protocol.txt");
                        List<string> msg = new List<string>();
                        while (!F.EndOfStream)
                        {
                            msg.Add(F.ReadLine());
                        }
                        for (int i=0;i<(int)Dota2ProtocolNumericUpDown.Value;i++)
                        {
                            string text = "";
                            text =msg[rand.Next(0,msg.Count+1)];
                            SendKeys.SendWait(text);
                            SendKeys.SendWait("{enter}");
                        }
                    }
                } 
            }
            else
            {
                textBox1.Text = "Не Бубни";
            }
        }

        private void recogn_rejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            textBox1.Text = "Не раслышал\r\n"+ e.Result.Text;
            
        }

        

        private void Confidence_trackBar_Scroll(object sender, EventArgs e)
        {
            Confidence = Confidence_trackBar.Value;
            Confidence_label.Text = Convert.ToString(Confidence) + "%";
        }

        

        


        private void Load_button_Click(object sender, EventArgs e)
        {
            FileStartEditer.Load_File(FileDataGridView);
        }

        private void Save_File_button_Click(object sender, EventArgs e)
        {
            FileStartEditer.Save_File(FileDataGridView);
            cancellationTokenSource.Cancel();
            StartRecognition();
        }

        private void FileDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            FileDataGridView[1, e.RowIndex].Value = openFileDialog1.FileName;

            if (e.RowIndex == FileDataGridView.RowCount - 1)
            {
                FileDataGridView.RowCount += 1;
            }


        }

        private void EXEOpenButton_Click(object sender, EventArgs e)
        {
            FileExeEditer.Load_File(EXEDataGridView);
        }

        private void EXESaveButton_Click(object sender, EventArgs e)
        {
            FileExeEditer.Save_File(EXEDataGridView);
            cancellationTokenSource.Cancel();
            StartRecognition();
        }
    }

    
}
