namespace Keylogger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.gbChoose = new System.Windows.Forms.GroupBox();
            this.rbToFile = new System.Windows.Forms.RadioButton();
            this.rbToTextbox = new System.Windows.Forms.RadioButton();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.tbGrab = new System.Windows.Forms.TextBox();
            this.chbBack = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEnabled = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.gbChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(314, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Keylogger";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(691, 495);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(153, 13);
            this.lblCopyright.TabIndex = 1;
            this.lblCopyright.Text = "Created by Matvey Bouhartsev";
            // 
            // gbChoose
            // 
            this.gbChoose.Controls.Add(this.lblError);
            this.gbChoose.Controls.Add(this.tbGrab);
            this.gbChoose.Controls.Add(this.lblFilename);
            this.gbChoose.Controls.Add(this.btnSaveFile);
            this.gbChoose.Controls.Add(this.rbToTextbox);
            this.gbChoose.Controls.Add(this.rbToFile);
            this.gbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbChoose.Location = new System.Drawing.Point(38, 76);
            this.gbChoose.Name = "gbChoose";
            this.gbChoose.Size = new System.Drawing.Size(776, 309);
            this.gbChoose.TabIndex = 2;
            this.gbChoose.TabStop = false;
            this.gbChoose.Text = "Choose type of grab";
            // 
            // rbToFile
            // 
            this.rbToFile.AutoSize = true;
            this.rbToFile.Checked = true;
            this.rbToFile.Location = new System.Drawing.Point(16, 48);
            this.rbToFile.Name = "rbToFile";
            this.rbToFile.Size = new System.Drawing.Size(158, 29);
            this.rbToFile.TabIndex = 0;
            this.rbToFile.TabStop = true;
            this.rbToFile.Text = "Write to the file";
            this.rbToFile.UseVisualStyleBackColor = true;
            // 
            // rbToTextbox
            // 
            this.rbToTextbox.AutoSize = true;
            this.rbToTextbox.Location = new System.Drawing.Point(16, 154);
            this.rbToTextbox.Name = "rbToTextbox";
            this.rbToTextbox.Size = new System.Drawing.Size(197, 29);
            this.rbToTextbox.TabIndex = 1;
            this.rbToTextbox.Text = "Write to the textbox";
            this.rbToTextbox.UseVisualStyleBackColor = true;
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileName = "Keylogger.txt";
            this.SaveFileDialog.Filter = "TXT|*.txt|Все файлы|*.*";
            this.SaveFileDialog.Title = "Save to the file";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(69, 90);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(176, 39);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save file to...";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoEllipsis = true;
            this.lblFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilename.ForeColor = System.Drawing.Color.Gray;
            this.lblFilename.Location = new System.Drawing.Point(276, 90);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblFilename.Size = new System.Drawing.Size(373, 39);
            this.lblFilename.TabIndex = 3;
            this.lblFilename.Text = "YourFileName";
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFilename.UseMnemonic = false;
            // 
            // tbGrab
            // 
            this.tbGrab.Location = new System.Drawing.Point(69, 202);
            this.tbGrab.Multiline = true;
            this.tbGrab.Name = "tbGrab";
            this.tbGrab.Size = new System.Drawing.Size(679, 84);
            this.tbGrab.TabIndex = 4;
            // 
            // chbBack
            // 
            this.chbBack.AutoSize = true;
            this.chbBack.Location = new System.Drawing.Point(36, 402);
            this.chbBack.Name = "chbBack";
            this.chbBack.Size = new System.Drawing.Size(188, 17);
            this.chbBack.TabIndex = 3;
            this.chbBack.Text = "Go to background mode after start";
            this.chbBack.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(254, 429);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(350, 60);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(668, 97);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(80, 25);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "ERROR";
            this.lblError.Visible = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(84, 420);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(80, 13);
            this.lblComment.TabIndex = 5;
            this.lblComment.Text = "(for \"file\" mode)";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(102, 22);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(92, 27);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "00:00:00";
            this.lblTime.Visible = false;
            // 
            // lblEnabled
            // 
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnabled.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblEnabled.Location = new System.Drawing.Point(672, 22);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(79, 27);
            this.lblEnabled.TabIndex = 6;
            this.lblEnabled.Text = "Disable";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(254, 429);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(350, 60);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 514);
            this.Controls.Add(this.lblEnabled);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chbBack);
            this.Controls.Add(this.gbChoose);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStop);
            this.Name = "Form1";
            this.Text = "Keylogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbChoose.ResumeLayout(false);
            this.gbChoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.GroupBox gbChoose;
        private System.Windows.Forms.RadioButton rbToTextbox;
        private System.Windows.Forms.RadioButton rbToFile;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TextBox tbGrab;
        private System.Windows.Forms.CheckBox chbBack;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEnabled;
        private System.Windows.Forms.Button btnStop;
    }
}

