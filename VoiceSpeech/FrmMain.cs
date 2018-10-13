﻿using System;
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
                spVoice.Voice = spVoice.GetVoices(string.Empty, string.Empty).Item(0);
                spVoice.Speak(txtContent.Text, spFlags);
                //Item(0)单词男声Sam
                //Item(1)单词男声Mike
                //Item(2)单词女声Mary
                //Item(3)中文发音，如果是英文，就依单词字母一个一个发音

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
    }
}
