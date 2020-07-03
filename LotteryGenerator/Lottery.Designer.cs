namespace LotteryGenerator
{
    partial class FrmHome
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.txtNum4 = new System.Windows.Forms.TextBox();
            this.txtNum5 = new System.Windows.Forms.TextBox();
            this.txtNum6 = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.BackColor = System.Drawing.Color.White;
            this.txtNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.ForeColor = System.Drawing.Color.Black;
            this.txtNumber1.Location = new System.Drawing.Point(140, 183);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(123, 98);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.Color.White;
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.ForeColor = System.Drawing.Color.Black;
            this.txtNum2.Location = new System.Drawing.Point(317, 183);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(123, 98);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // txtNum3
            // 
            this.txtNum3.BackColor = System.Drawing.Color.White;
            this.txtNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.ForeColor = System.Drawing.Color.Black;
            this.txtNum3.Location = new System.Drawing.Point(494, 183);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(123, 98);
            this.txtNum3.TabIndex = 3;
            this.txtNum3.TextChanged += new System.EventHandler(this.txtNum3_TextChanged);
            // 
            // txtNum4
            // 
            this.txtNum4.BackColor = System.Drawing.Color.White;
            this.txtNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum4.ForeColor = System.Drawing.Color.Black;
            this.txtNum4.Location = new System.Drawing.Point(671, 183);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(123, 98);
            this.txtNum4.TabIndex = 4;
            this.txtNum4.TextChanged += new System.EventHandler(this.txtNum4_TextChanged);
            // 
            // txtNum5
            // 
            this.txtNum5.BackColor = System.Drawing.Color.White;
            this.txtNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum5.ForeColor = System.Drawing.Color.Black;
            this.txtNum5.Location = new System.Drawing.Point(848, 183);
            this.txtNum5.Name = "txtNum5";
            this.txtNum5.Size = new System.Drawing.Size(123, 98);
            this.txtNum5.TabIndex = 5;
            this.txtNum5.TextChanged += new System.EventHandler(this.txtNum5_TextChanged);
            // 
            // txtNum6
            // 
            this.txtNum6.BackColor = System.Drawing.Color.White;
            this.txtNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum6.ForeColor = System.Drawing.Color.Black;
            this.txtNum6.Location = new System.Drawing.Point(1025, 183);
            this.txtNum6.Name = "txtNum6";
            this.txtNum6.Size = new System.Drawing.Size(123, 98);
            this.txtNum6.TabIndex = 6;
            this.txtNum6.TextChanged += new System.EventHandler(this.txtNum6_TextChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Gray;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Location = new System.Drawing.Point(542, 313);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(197, 72);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(1084, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 56);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Gray;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(700, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(501, 69);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BOB\'S LOTTERY";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Gray;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(13, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(179, 69);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "22:22";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Gray;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(306, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(297, 55);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "July 03 2020";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Gray;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(13, 88);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(157, 55);
            this.lblDay.TabIndex = 12;
            this.lblDay.Text = "Friday";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::LotteryGenerator.Properties.Resources.NationalLotto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 568);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtNum6);
            this.Controls.Add(this.txtNum5);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNumber1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Text = "ab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum4;
        private System.Windows.Forms.TextBox txtNum5;
        private System.Windows.Forms.TextBox txtNum6;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Timer timer;
    }
}

