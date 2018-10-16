using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SpeechLib;

namespace VoiceSpeech
{
    public partial class FrmMain : Form
    {
        SpeechVoiceSpeakFlags spFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
        SpVoice spVoice = new SpVoice();//声源
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 语音播报
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBegin_Click(object sender, EventArgs e)
        {
            try
            {
                if (spVoice != null)
                {
                    spVoice.Resume();
                }
                //spVoice.Voice = spVoice.GetVoices(string.Empty, string.Empty).Item(1);
                spVoice.Speak(txtContent.Text, spFlags);

                //生成文件
                //try
                //{
                //    SpeechStreamFileMode SpFileMode = SpeechStreamFileMode.SSFMCreateForWrite;
                //    SpFileStream SpFileStream = new SpFileStream();
                //    SpFileStream.Open(@"C:\Users\EMEWE\Desktop\Test.wav", SpFileMode, false);
                //    spVoice.AudioOutputStream = SpFileStream;//设定voice的输出为Stream
                //    spVoice.Speak(txtContent.Text.Trim(), spFlags);
                //    spVoice.WaitUntilDone(Timeout.Infinite);//Using System.Threading;
                //    SpFileStream.Close();
                //    MessageBox.Show("生成成功！");
                //}
                //catch { MessageBox.Show("生成失败！"); }
            }
            catch { }
        }

        private void btnMinusV_Click(object sender, EventArgs e)
        {
            if (spVoice.Volume >= 10)
            {
                spVoice.Volume -= 10;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            spVoice.Pause();
        }

        private void btnVoiceSpeed_Click(object sender, EventArgs e)
        {
            if (spVoice.Rate <= 5 )
            {
                spVoice.Rate += 1;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (spVoice.Rate >= -5)
            {
                spVoice.Rate -= 1;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (spVoice.Volume < 100)
            {
                spVoice.Volume += 10;
            }
        }
        public void NewRead()
        {
            string wavPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Sounds\\ring.wav";//要读的音频文件地址
            //SpVoiceClass pp = new SpeechLib.SpVoiceClass();
            //SpeechLib.SpFileStreamClass spFs = new SpFileStreamClass();
            //spFs.Open(wavPath, SpeechLib.SpeechStreamFileMode.SSFMOpenForRead, true);
            //SpeechLib.ISpeechBaseStream Istream = spFs as SpeechLib.ISpeechBaseStream;
            //SoundPlayer soundPlayer = new SoundPlayer();
            //soundPlayer.SoundLocation = wavPath;
            //soundPlayer.Load();
            //soundPlayer.Play();
            SpeechVoiceSpeakFlags spFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice spVoice = new SpVoice();//声源
            spVoice.Rate = -5;//速度
            spVoice.Volume = 100;
            //播放
            //spVoice.WaitUntilDone(-1);
            //spVoice.SpeakStream(Istream, spFlags);
            spVoice.WaitUntilDone(-1);
            spVoice.Speak(txtContent.Text, spFlags);
            //spFs.Close();
        }
    }
}
