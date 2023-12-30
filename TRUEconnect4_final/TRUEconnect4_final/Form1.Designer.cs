namespace TRUEconnect4_final
{
    partial class gameForm
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
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.gbScoreboard = new System.Windows.Forms.GroupBox();
            this.txtRWin = new System.Windows.Forms.TextBox();
            this.lblRedWin = new System.Windows.Forms.Label();
            this.txtYWin = new System.Windows.Forms.TextBox();
            this.lblYellowWin = new System.Windows.Forms.Label();
            this.btnResetScore = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.Connect4Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.gbScoreboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGame
            // 
            this.pbGame.Location = new System.Drawing.Point(34, 101);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(703, 603);
            this.pbGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGame.TabIndex = 0;
            this.pbGame.TabStop = false;
            this.pbGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGame_Paint);
            this.pbGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbGame_MouseClick);
            // 
            // gbScoreboard
            // 
            this.gbScoreboard.Controls.Add(this.txtRWin);
            this.gbScoreboard.Controls.Add(this.lblRedWin);
            this.gbScoreboard.Controls.Add(this.txtYWin);
            this.gbScoreboard.Controls.Add(this.lblYellowWin);
            this.gbScoreboard.Controls.Add(this.btnResetScore);
            this.gbScoreboard.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.gbScoreboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.gbScoreboard.Location = new System.Drawing.Point(762, 143);
            this.gbScoreboard.Name = "gbScoreboard";
            this.gbScoreboard.Size = new System.Drawing.Size(142, 244);
            this.gbScoreboard.TabIndex = 2;
            this.gbScoreboard.TabStop = false;
            this.gbScoreboard.Text = "Scoreboard";
            // 
            // txtRWin
            // 
            this.txtRWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRWin.ForeColor = System.Drawing.Color.White;
            this.txtRWin.Location = new System.Drawing.Point(10, 112);
            this.txtRWin.Multiline = true;
            this.txtRWin.Name = "txtRWin";
            this.txtRWin.ReadOnly = true;
            this.txtRWin.Size = new System.Drawing.Size(119, 30);
            this.txtRWin.TabIndex = 0;
            this.txtRWin.TabStop = false;
            // 
            // lblRedWin
            // 
            this.lblRedWin.AutoSize = true;
            this.lblRedWin.Location = new System.Drawing.Point(7, 92);
            this.lblRedWin.Name = "lblRedWin";
            this.lblRedWin.Size = new System.Drawing.Size(71, 15);
            this.lblRedWin.TabIndex = 5;
            this.lblRedWin.Text = "Red Wins:";
            // 
            // txtYWin
            // 
            this.txtYWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtYWin.ForeColor = System.Drawing.Color.White;
            this.txtYWin.Location = new System.Drawing.Point(10, 51);
            this.txtYWin.Multiline = true;
            this.txtYWin.Name = "txtYWin";
            this.txtYWin.ReadOnly = true;
            this.txtYWin.Size = new System.Drawing.Size(119, 30);
            this.txtYWin.TabIndex = 0;
            this.txtYWin.TabStop = false;
            // 
            // lblYellowWin
            // 
            this.lblYellowWin.AutoSize = true;
            this.lblYellowWin.Location = new System.Drawing.Point(7, 31);
            this.lblYellowWin.Name = "lblYellowWin";
            this.lblYellowWin.Size = new System.Drawing.Size(95, 15);
            this.lblYellowWin.TabIndex = 3;
            this.lblYellowWin.Text = "Yellow Wins:";
            // 
            // btnResetScore
            // 
            this.btnResetScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnResetScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetScore.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.btnResetScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnResetScore.Location = new System.Drawing.Point(10, 152);
            this.btnResetScore.Name = "btnResetScore";
            this.btnResetScore.Size = new System.Drawing.Size(119, 77);
            this.btnResetScore.TabIndex = 1;
            this.btnResetScore.Text = "Reset Scores";
            this.btnResetScore.UseVisualStyleBackColor = false;
            this.btnResetScore.Click += new System.EventHandler(this.btnResetScore_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuit.Location = new System.Drawing.Point(762, 616);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(142, 85);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtTurn
            // 
            this.txtTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTurn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurn.ForeColor = System.Drawing.Color.White;
            this.txtTurn.Location = new System.Drawing.Point(762, 101);
            this.txtTurn.Multiline = true;
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.ReadOnly = true;
            this.txtTurn.Size = new System.Drawing.Size(129, 30);
            this.txtTurn.TabIndex = 0;
            this.txtTurn.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.lblTitle.Location = new System.Drawing.Point(146, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 83);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "CONNECT 4 >:(";
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewGame.Location = new System.Drawing.Point(762, 416);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(142, 170);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Connect4Timer
            // 
            this.Connect4Timer.Tick += new System.EventHandler(this.Connect4Timer_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(952, 724);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbScoreboard);
            this.Controls.Add(this.pbGame);
            this.Name = "gameForm";
            this.Text = "Angry Connect 4 >:(";
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.gbScoreboard.ResumeLayout(false);
            this.gbScoreboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.GroupBox gbScoreboard;
        private System.Windows.Forms.Button btnResetScore;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtTurn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtRWin;
        private System.Windows.Forms.Label lblRedWin;
        private System.Windows.Forms.TextBox txtYWin;
        private System.Windows.Forms.Label lblYellowWin;
        private System.Windows.Forms.Timer Connect4Timer;
    }
}

