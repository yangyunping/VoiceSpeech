﻿using SpeechLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceSpeech
{
    public static class SpeechRead
    {
        public static void NewRead(string content)
        {
            string wavPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "ring.wav";//要读的音频文件地址
            SpVoiceClass pp = new SpeechLib.SpVoiceClass();
            SpeechLib.SpFileStreamClass spFs = new SpFileStreamClass();
            spFs.Open(wavPath, SpeechLib.SpeechStreamFileMode.SSFMOpenForRead, true);
            SpeechLib.ISpeechBaseStream Istream = spFs as SpeechLib.ISpeechBaseStream;
            //SoundPlayer soundPlayer = new SoundPlayer();
            //soundPlayer.SoundLocation = wavPath;
            //soundPlayer.Load();
            //soundPlayer.Play();
            SpeechVoiceSpeakFlags spFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice spVoice = new SpVoice();//声源
            spVoice.Rate = -5;//速度
            spVoice.Volume = 100;
            //播放
            spVoice.SpeakStream(Istream, spFlags);
            spVoice.WaitUntilDone(-1);
            spVoice.Speak(content, spFlags);
            spFs.Close();
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
    }
}
