namespace Flags_2
{
    partial class frmFlags
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.picGermanyFlag = new System.Windows.Forms.PictureBox();
            this.picFranceFlag = new System.Windows.Forms.PictureBox();
            this.picFinlandFlag = new System.Windows.Forms.PictureBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangeLabelColortoYellow = new System.Windows.Forms.Button();
            this.btnChangeLabelColortoDefault = new System.Windows.Forms.Button();
            this.btnChangeFomColortoGreen = new System.Windows.Forms.Button();
            this.btnChangeFormColortoDefault = new System.Windows.Forms.Button();
            this.btnHideFlags = new System.Windows.Forms.Button();
            this.btnShowFlags = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tmrNumber1 = new System.Windows.Forms.Timer(this.components);
            this.tmrNumber2 = new System.Windows.Forms.Timer(this.components);
            this.tmrNumber3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGermanyFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFranceFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinlandFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(247, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(295, 16);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Click a flag to see the name of the country";
            // 
            // picGermanyFlag
            // 
            this.picGermanyFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGermanyFlag.Image = global::Flags_2.Properties.Resources.Germany;
            this.picGermanyFlag.Location = new System.Drawing.Point(589, 66);
            this.picGermanyFlag.Name = "picGermanyFlag";
            this.picGermanyFlag.Size = new System.Drawing.Size(122, 72);
            this.picGermanyFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGermanyFlag.TabIndex = 3;
            this.picGermanyFlag.TabStop = false;
            this.picGermanyFlag.Click += new System.EventHandler(this.picGermanyFlag_Click);
            // 
            // picFranceFlag
            // 
            this.picFranceFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFranceFlag.Image = global::Flags_2.Properties.Resources.France;
            this.picFranceFlag.Location = new System.Drawing.Point(309, 66);
            this.picFranceFlag.Name = "picFranceFlag";
            this.picFranceFlag.Size = new System.Drawing.Size(122, 72);
            this.picFranceFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFranceFlag.TabIndex = 2;
            this.picFranceFlag.TabStop = false;
            this.picFranceFlag.Click += new System.EventHandler(this.picFranceFlag_Click);
            // 
            // picFinlandFlag
            // 
            this.picFinlandFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFinlandFlag.Image = global::Flags_2.Properties.Resources.Finland;
            this.picFinlandFlag.Location = new System.Drawing.Point(38, 66);
            this.picFinlandFlag.Name = "picFinlandFlag";
            this.picFinlandFlag.Size = new System.Drawing.Size(122, 72);
            this.picFinlandFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFinlandFlag.TabIndex = 1;
            this.picFinlandFlag.TabStop = false;
            this.picFinlandFlag.Click += new System.EventHandler(this.picFinlandFlag_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Red;
            this.lblCountry.Location = new System.Drawing.Point(225, 182);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(414, 38);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(163, 264);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(609, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangeLabelColortoYellow
            // 
            this.btnChangeLabelColortoYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLabelColortoYellow.ForeColor = System.Drawing.Color.Maroon;
            this.btnChangeLabelColortoYellow.Location = new System.Drawing.Point(12, 326);
            this.btnChangeLabelColortoYellow.Name = "btnChangeLabelColortoYellow";
            this.btnChangeLabelColortoYellow.Size = new System.Drawing.Size(307, 37);
            this.btnChangeLabelColortoYellow.TabIndex = 7;
            this.btnChangeLabelColortoYellow.Text = "Change Label Color to Yellow";
            this.btnChangeLabelColortoYellow.UseVisualStyleBackColor = true;
            this.btnChangeLabelColortoYellow.Click += new System.EventHandler(this.btnChangeLabelColortoYellow_Click);
            // 
            // btnChangeLabelColortoDefault
            // 
            this.btnChangeLabelColortoDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLabelColortoDefault.ForeColor = System.Drawing.Color.Maroon;
            this.btnChangeLabelColortoDefault.Location = new System.Drawing.Point(12, 378);
            this.btnChangeLabelColortoDefault.Name = "btnChangeLabelColortoDefault";
            this.btnChangeLabelColortoDefault.Size = new System.Drawing.Size(307, 37);
            this.btnChangeLabelColortoDefault.TabIndex = 8;
            this.btnChangeLabelColortoDefault.Text = "Change Label Color to Default";
            this.btnChangeLabelColortoDefault.UseVisualStyleBackColor = true;
            this.btnChangeLabelColortoDefault.Click += new System.EventHandler(this.btnChangeLabelColortoDefault_Click);
            // 
            // btnChangeFomColortoGreen
            // 
            this.btnChangeFomColortoGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFomColortoGreen.ForeColor = System.Drawing.Color.Maroon;
            this.btnChangeFomColortoGreen.Location = new System.Drawing.Point(446, 326);
            this.btnChangeFomColortoGreen.Name = "btnChangeFomColortoGreen";
            this.btnChangeFomColortoGreen.Size = new System.Drawing.Size(307, 37);
            this.btnChangeFomColortoGreen.TabIndex = 9;
            this.btnChangeFomColortoGreen.Text = "Change Form Color to Blue";
            this.btnChangeFomColortoGreen.UseVisualStyleBackColor = true;
            this.btnChangeFomColortoGreen.Click += new System.EventHandler(this.btnChangeFomColortoGreen_Click);
            // 
            // btnChangeFormColortoDefault
            // 
            this.btnChangeFormColortoDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFormColortoDefault.ForeColor = System.Drawing.Color.Maroon;
            this.btnChangeFormColortoDefault.Location = new System.Drawing.Point(446, 378);
            this.btnChangeFormColortoDefault.Name = "btnChangeFormColortoDefault";
            this.btnChangeFormColortoDefault.Size = new System.Drawing.Size(307, 37);
            this.btnChangeFormColortoDefault.TabIndex = 10;
            this.btnChangeFormColortoDefault.Text = "Change Label Color to Default";
            this.btnChangeFormColortoDefault.UseVisualStyleBackColor = true;
            this.btnChangeFormColortoDefault.Click += new System.EventHandler(this.btnChangeFormColortoDefault_Click);
            // 
            // btnHideFlags
            // 
            this.btnHideFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideFlags.ForeColor = System.Drawing.Color.Maroon;
            this.btnHideFlags.Location = new System.Drawing.Point(12, 432);
            this.btnHideFlags.Name = "btnHideFlags";
            this.btnHideFlags.Size = new System.Drawing.Size(307, 37);
            this.btnHideFlags.TabIndex = 11;
            this.btnHideFlags.Text = "Hide Flags";
            this.btnHideFlags.UseVisualStyleBackColor = true;
            this.btnHideFlags.Click += new System.EventHandler(this.btnHideFlags_Click);
            // 
            // btnShowFlags
            // 
            this.btnShowFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFlags.ForeColor = System.Drawing.Color.Maroon;
            this.btnShowFlags.Location = new System.Drawing.Point(446, 432);
            this.btnShowFlags.Name = "btnShowFlags";
            this.btnShowFlags.Size = new System.Drawing.Size(307, 37);
            this.btnShowFlags.TabIndex = 12;
            this.btnShowFlags.Text = "Show Flags";
            this.btnShowFlags.UseVisualStyleBackColor = true;
            this.btnShowFlags.Click += new System.EventHandler(this.btnShowFlags_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Maroon;
            this.btnStart.Location = new System.Drawing.Point(38, 264);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 31);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Maroon;
            this.btnStop.Location = new System.Drawing.Point(494, 264);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 31);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tmrNumber1
            // 
            this.tmrNumber1.Interval = 5000;
            this.tmrNumber1.Tick += new System.EventHandler(this.tmrNumber1_Tick);
            // 
            // tmrNumber2
            // 
            this.tmrNumber2.Interval = 5000;
            this.tmrNumber2.Tick += new System.EventHandler(this.tmrNumber2_Tick);
            // 
            // tmrNumber3
            // 
            this.tmrNumber3.Interval = 5000;
            this.tmrNumber3.Tick += new System.EventHandler(this.tmrNumber3_Tick);
            // 
            // frmFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 578);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnShowFlags);
            this.Controls.Add(this.btnHideFlags);
            this.Controls.Add(this.btnChangeFormColortoDefault);
            this.Controls.Add(this.btnChangeFomColortoGreen);
            this.Controls.Add(this.btnChangeLabelColortoDefault);
            this.Controls.Add(this.btnChangeLabelColortoYellow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.picGermanyFlag);
            this.Controls.Add(this.picFranceFlag);
            this.Controls.Add(this.picFinlandFlag);
            this.Controls.Add(this.lblInstruction);
            this.Name = "frmFlags";
            this.Text = "Flags";
            this.Load += new System.EventHandler(this.frmFlags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGermanyFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFranceFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinlandFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox picFinlandFlag;
        private System.Windows.Forms.PictureBox picFranceFlag;
        private System.Windows.Forms.PictureBox picGermanyFlag;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangeLabelColortoYellow;
        private System.Windows.Forms.Button btnChangeLabelColortoDefault;
        private System.Windows.Forms.Button btnChangeFomColortoGreen;
        private System.Windows.Forms.Button btnChangeFormColortoDefault;
        private System.Windows.Forms.Button btnHideFlags;
        private System.Windows.Forms.Button btnShowFlags;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer tmrNumber1;
        private System.Windows.Forms.Timer tmrNumber2;
        private System.Windows.Forms.Timer tmrNumber3;
    }
}

