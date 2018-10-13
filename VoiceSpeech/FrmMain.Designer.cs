namespace VoiceSpeech
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnMinusV = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAddV = new System.Windows.Forms.Button();
            this.btnVoiceSpeed = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContent.Location = new System.Drawing.Point(0, 0);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(394, 297);
            this.txtContent.TabIndex = 0;
            // 
            // btnMinusV
            // 
            this.btnMinusV.Location = new System.Drawing.Point(265, 382);
            this.btnMinusV.Name = "btnMinusV";
            this.btnMinusV.Size = new System.Drawing.Size(78, 38);
            this.btnMinusV.TabIndex = 1;
            this.btnMinusV.Text = "降低音量";
            this.btnMinusV.UseVisualStyleBackColor = true;
            this.btnMinusV.Click += new System.EventHandler(this.btnMinusV_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(43, 323);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(78, 38);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "播放";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(43, 382);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 38);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAddV
            // 
            this.btnAddV.Location = new System.Drawing.Point(265, 323);
            this.btnAddV.Name = "btnAddV";
            this.btnAddV.Size = new System.Drawing.Size(78, 38);
            this.btnAddV.TabIndex = 4;
            this.btnAddV.Text = "增大声音";
            this.btnAddV.UseVisualStyleBackColor = true;
            this.btnAddV.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnVoiceSpeed
            // 
            this.btnVoiceSpeed.Location = new System.Drawing.Point(154, 323);
            this.btnVoiceSpeed.Name = "btnVoiceSpeed";
            this.btnVoiceSpeed.Size = new System.Drawing.Size(78, 38);
            this.btnVoiceSpeed.TabIndex = 5;
            this.btnVoiceSpeed.Text = "增快语速";
            this.btnVoiceSpeed.UseVisualStyleBackColor = true;
            this.btnVoiceSpeed.Click += new System.EventHandler(this.btnVoiceSpeed_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(154, 382);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(78, 38);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "减慢语速";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 436);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnVoiceSpeed);
            this.Controls.Add(this.btnAddV);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.btnMinusV);
            this.Controls.Add(this.txtContent);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "语音播报";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnMinusV;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAddV;
        private System.Windows.Forms.Button btnVoiceSpeed;
        private System.Windows.Forms.Button btnMinus;
    }
}

