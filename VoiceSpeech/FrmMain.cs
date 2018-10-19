using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
                Task.Factory.StartNew(new Action(()=>
                  SpeechRead.NewRead(txtContent.Text)
                ));
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
    }
}
