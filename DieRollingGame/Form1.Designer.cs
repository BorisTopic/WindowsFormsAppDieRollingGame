
namespace DieRollingGame
{
    partial class Form1
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
            this.lblError = new System.Windows.Forms.Label();
            this.richTxtBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.picBoxDiceImage = new System.Windows.Forms.PictureBox();
            this.txtBoxUserGuess = new System.Windows.Forms.TextBox();
            this.lblEnterGuess = new System.Windows.Forms.Label();
            this.groupBoxGameInfo = new System.Windows.Forms.GroupBox();
            this.lblTimesLost = new System.Windows.Forms.Label();
            this.lblTimesWon = new System.Windows.Forms.Label();
            this.lblTimesPlayed = new System.Windows.Forms.Label();
            this.lblNumTimesLost = new System.Windows.Forms.Label();
            this.lblNumTimesWon = new System.Windows.Forms.Label();
            this.lblNumTimesPlayed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiceImage)).BeginInit();
            this.groupBoxGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(260, 237);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 15;
            // 
            // richTxtBoxDisplay
            // 
            this.richTxtBoxDisplay.Location = new System.Drawing.Point(13, 439);
            this.richTxtBoxDisplay.Name = "richTxtBoxDisplay";
            this.richTxtBoxDisplay.Size = new System.Drawing.Size(575, 203);
            this.richTxtBoxDisplay.TabIndex = 14;
            this.richTxtBoxDisplay.Text = "FACE       FREQUENCY          PERCENT               NUMBER OF TIMES GUESSED";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(212, 358);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(212, 312);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 12;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picBoxDiceImage
            // 
            this.picBoxDiceImage.Location = new System.Drawing.Point(23, 291);
            this.picBoxDiceImage.Name = "picBoxDiceImage";
            this.picBoxDiceImage.Size = new System.Drawing.Size(128, 112);
            this.picBoxDiceImage.TabIndex = 11;
            this.picBoxDiceImage.TabStop = false;
            // 
            // txtBoxUserGuess
            // 
            this.txtBoxUserGuess.Location = new System.Drawing.Point(176, 234);
            this.txtBoxUserGuess.MaxLength = 1;
            this.txtBoxUserGuess.Name = "txtBoxUserGuess";
            this.txtBoxUserGuess.Size = new System.Drawing.Size(78, 22);
            this.txtBoxUserGuess.TabIndex = 10;
            // 
            // lblEnterGuess
            // 
            this.lblEnterGuess.AutoSize = true;
            this.lblEnterGuess.Location = new System.Drawing.Point(10, 234);
            this.lblEnterGuess.Name = "lblEnterGuess";
            this.lblEnterGuess.Size = new System.Drawing.Size(160, 17);
            this.lblEnterGuess.TabIndex = 9;
            this.lblEnterGuess.Text = "Enter Your Guess (1-6):";
            // 
            // groupBoxGameInfo
            // 
            this.groupBoxGameInfo.Controls.Add(this.lblTimesLost);
            this.groupBoxGameInfo.Controls.Add(this.lblTimesWon);
            this.groupBoxGameInfo.Controls.Add(this.lblTimesPlayed);
            this.groupBoxGameInfo.Controls.Add(this.lblNumTimesLost);
            this.groupBoxGameInfo.Controls.Add(this.lblNumTimesWon);
            this.groupBoxGameInfo.Controls.Add(this.lblNumTimesPlayed);
            this.groupBoxGameInfo.Location = new System.Drawing.Point(13, 12);
            this.groupBoxGameInfo.Name = "groupBoxGameInfo";
            this.groupBoxGameInfo.Size = new System.Drawing.Size(303, 194);
            this.groupBoxGameInfo.TabIndex = 8;
            this.groupBoxGameInfo.TabStop = false;
            this.groupBoxGameInfo.Text = "Game Info";
            // 
            // lblTimesLost
            // 
            this.lblTimesLost.AutoSize = true;
            this.lblTimesLost.Location = new System.Drawing.Point(212, 120);
            this.lblTimesLost.Name = "lblTimesLost";
            this.lblTimesLost.Size = new System.Drawing.Size(16, 17);
            this.lblTimesLost.TabIndex = 5;
            this.lblTimesLost.Text = "0";
            // 
            // lblTimesWon
            // 
            this.lblTimesWon.AutoSize = true;
            this.lblTimesWon.Location = new System.Drawing.Point(212, 83);
            this.lblTimesWon.Name = "lblTimesWon";
            this.lblTimesWon.Size = new System.Drawing.Size(16, 17);
            this.lblTimesWon.TabIndex = 4;
            this.lblTimesWon.Text = "0";
            // 
            // lblTimesPlayed
            // 
            this.lblTimesPlayed.AutoSize = true;
            this.lblTimesPlayed.Location = new System.Drawing.Point(212, 44);
            this.lblTimesPlayed.Name = "lblTimesPlayed";
            this.lblTimesPlayed.Size = new System.Drawing.Size(16, 17);
            this.lblTimesPlayed.TabIndex = 3;
            this.lblTimesPlayed.Text = "0";
            // 
            // lblNumTimesLost
            // 
            this.lblNumTimesLost.AutoSize = true;
            this.lblNumTimesLost.Location = new System.Drawing.Point(6, 120);
            this.lblNumTimesLost.Name = "lblNumTimesLost";
            this.lblNumTimesLost.Size = new System.Drawing.Size(151, 17);
            this.lblNumTimesLost.TabIndex = 2;
            this.lblNumTimesLost.Text = "Number of Times Lost:";
            // 
            // lblNumTimesWon
            // 
            this.lblNumTimesWon.AutoSize = true;
            this.lblNumTimesWon.Location = new System.Drawing.Point(6, 83);
            this.lblNumTimesWon.Name = "lblNumTimesWon";
            this.lblNumTimesWon.Size = new System.Drawing.Size(153, 17);
            this.lblNumTimesWon.TabIndex = 1;
            this.lblNumTimesWon.Text = "Number of Times Won:";
            // 
            // lblNumTimesPlayed
            // 
            this.lblNumTimesPlayed.AutoSize = true;
            this.lblNumTimesPlayed.Location = new System.Drawing.Point(6, 44);
            this.lblNumTimesPlayed.Name = "lblNumTimesPlayed";
            this.lblNumTimesPlayed.Size = new System.Drawing.Size(167, 17);
            this.lblNumTimesPlayed.TabIndex = 0;
            this.lblNumTimesPlayed.Text = "Number of Times Played:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 654);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.richTxtBoxDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picBoxDiceImage);
            this.Controls.Add(this.txtBoxUserGuess);
            this.Controls.Add(this.lblEnterGuess);
            this.Controls.Add(this.groupBoxGameInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiceImage)).EndInit();
            this.groupBoxGameInfo.ResumeLayout(false);
            this.groupBoxGameInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RichTextBox richTxtBoxDisplay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox picBoxDiceImage;
        private System.Windows.Forms.TextBox txtBoxUserGuess;
        private System.Windows.Forms.Label lblEnterGuess;
        private System.Windows.Forms.GroupBox groupBoxGameInfo;
        private System.Windows.Forms.Label lblTimesLost;
        private System.Windows.Forms.Label lblTimesWon;
        private System.Windows.Forms.Label lblTimesPlayed;
        private System.Windows.Forms.Label lblNumTimesLost;
        private System.Windows.Forms.Label lblNumTimesWon;
        private System.Windows.Forms.Label lblNumTimesPlayed;
    }
}

