namespace TicTacToe
{
    partial class TicTacToeGUI
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
            if(disposing && (components != null))
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
            this.zeroZeroButton = new System.Windows.Forms.Button();
            this.zeroOneButton = new System.Windows.Forms.Button();
            this.zeroTwoButton = new System.Windows.Forms.Button();
            this.oneTwoButton = new System.Windows.Forms.Button();
            this.oneOneButton = new System.Windows.Forms.Button();
            this.oneZeroButton = new System.Windows.Forms.Button();
            this.twoTwoButton = new System.Windows.Forms.Button();
            this.twoOneButton = new System.Windows.Forms.Button();
            this.twoZeroButton = new System.Windows.Forms.Button();
            this.gameResultTextBox = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.gameBoard = new System.Windows.Forms.Panel();
            this.gameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeroZeroButton
            // 
            this.zeroZeroButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.zeroZeroButton.Enabled = false;
            this.zeroZeroButton.FlatAppearance.BorderSize = 0;
            this.zeroZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.zeroZeroButton.Location = new System.Drawing.Point(3, 3);
            this.zeroZeroButton.Name = "zeroZeroButton";
            this.zeroZeroButton.Size = new System.Drawing.Size(75, 53);
            this.zeroZeroButton.TabIndex = 0;
            this.zeroZeroButton.TabStop = false;
            this.zeroZeroButton.UseVisualStyleBackColor = true;
            this.zeroZeroButton.Click += new System.EventHandler(this.zeroZeroButton_Click);
            // 
            // zeroOneButton
            // 
            this.zeroOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.zeroOneButton.Location = new System.Drawing.Point(84, 3);
            this.zeroOneButton.Name = "zeroOneButton";
            this.zeroOneButton.Size = new System.Drawing.Size(75, 53);
            this.zeroOneButton.TabIndex = 1;
            this.zeroOneButton.TabStop = false;
            this.zeroOneButton.UseVisualStyleBackColor = true;
            this.zeroOneButton.Click += new System.EventHandler(this.zeroOneButton_Click);
            // 
            // zeroTwoButton
            // 
            this.zeroTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.zeroTwoButton.Location = new System.Drawing.Point(165, 3);
            this.zeroTwoButton.Name = "zeroTwoButton";
            this.zeroTwoButton.Size = new System.Drawing.Size(75, 53);
            this.zeroTwoButton.TabIndex = 2;
            this.zeroTwoButton.TabStop = false;
            this.zeroTwoButton.UseVisualStyleBackColor = true;
            this.zeroTwoButton.Click += new System.EventHandler(this.zeroTwoButton_Click);
            // 
            // oneTwoButton
            // 
            this.oneTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.oneTwoButton.Location = new System.Drawing.Point(165, 62);
            this.oneTwoButton.Name = "oneTwoButton";
            this.oneTwoButton.Size = new System.Drawing.Size(75, 53);
            this.oneTwoButton.TabIndex = 5;
            this.oneTwoButton.TabStop = false;
            this.oneTwoButton.UseVisualStyleBackColor = true;
            this.oneTwoButton.Click += new System.EventHandler(this.oneTwoButton_Click);
            // 
            // oneOneButton
            // 
            this.oneOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.oneOneButton.Location = new System.Drawing.Point(84, 62);
            this.oneOneButton.Name = "oneOneButton";
            this.oneOneButton.Size = new System.Drawing.Size(75, 53);
            this.oneOneButton.TabIndex = 4;
            this.oneOneButton.TabStop = false;
            this.oneOneButton.UseVisualStyleBackColor = true;
            this.oneOneButton.Click += new System.EventHandler(this.oneOneButton_Click);
            // 
            // oneZeroButton
            // 
            this.oneZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.oneZeroButton.Location = new System.Drawing.Point(3, 62);
            this.oneZeroButton.Name = "oneZeroButton";
            this.oneZeroButton.Size = new System.Drawing.Size(75, 53);
            this.oneZeroButton.TabIndex = 3;
            this.oneZeroButton.TabStop = false;
            this.oneZeroButton.UseVisualStyleBackColor = true;
            this.oneZeroButton.Click += new System.EventHandler(this.oneZeroButton_Click);
            // 
            // twoTwoButton
            // 
            this.twoTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.twoTwoButton.Location = new System.Drawing.Point(165, 121);
            this.twoTwoButton.Name = "twoTwoButton";
            this.twoTwoButton.Size = new System.Drawing.Size(75, 53);
            this.twoTwoButton.TabIndex = 8;
            this.twoTwoButton.TabStop = false;
            this.twoTwoButton.UseVisualStyleBackColor = true;
            this.twoTwoButton.Click += new System.EventHandler(this.twoTwoButton_Click);
            // 
            // twoOneButton
            // 
            this.twoOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.twoOneButton.Location = new System.Drawing.Point(84, 121);
            this.twoOneButton.Name = "twoOneButton";
            this.twoOneButton.Size = new System.Drawing.Size(75, 53);
            this.twoOneButton.TabIndex = 7;
            this.twoOneButton.TabStop = false;
            this.twoOneButton.UseVisualStyleBackColor = true;
            this.twoOneButton.Click += new System.EventHandler(this.twoOneButton_Click);
            // 
            // twoZeroButton
            // 
            this.twoZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.twoZeroButton.Location = new System.Drawing.Point(3, 121);
            this.twoZeroButton.Name = "twoZeroButton";
            this.twoZeroButton.Size = new System.Drawing.Size(75, 53);
            this.twoZeroButton.TabIndex = 6;
            this.twoZeroButton.TabStop = false;
            this.twoZeroButton.UseVisualStyleBackColor = true;
            this.twoZeroButton.Click += new System.EventHandler(this.twoZeroButton_Click);
            // 
            // gameResultTextBox
            // 
            this.gameResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameResultTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gameResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameResultTextBox.Location = new System.Drawing.Point(32, 198);
            this.gameResultTextBox.Name = "gameResultTextBox";
            this.gameResultTextBox.ReadOnly = true;
            this.gameResultTextBox.Size = new System.Drawing.Size(237, 23);
            this.gameResultTextBox.TabIndex = 9;
            this.gameResultTextBox.TabStop = false;
            this.gameResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gameResultTextBox.Enter += new System.EventHandler(this.gameResultTextBox_Enter);
            this.gameResultTextBox.MouseEnter += new System.EventHandler(this.gameResultTextBox_MouseEnter);
            this.gameResultTextBox.MouseLeave += new System.EventHandler(this.gameResultTextBox_MouseLeave);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(67, 224);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 26);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(148, 224);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 26);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gameBoard
            // 
            this.gameBoard.Controls.Add(this.zeroZeroButton);
            this.gameBoard.Controls.Add(this.zeroOneButton);
            this.gameBoard.Controls.Add(this.zeroTwoButton);
            this.gameBoard.Controls.Add(this.oneZeroButton);
            this.gameBoard.Controls.Add(this.twoTwoButton);
            this.gameBoard.Controls.Add(this.oneOneButton);
            this.gameBoard.Controls.Add(this.twoOneButton);
            this.gameBoard.Controls.Add(this.oneTwoButton);
            this.gameBoard.Controls.Add(this.twoZeroButton);
            this.gameBoard.Location = new System.Drawing.Point(29, 12);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(243, 180);
            this.gameBoard.TabIndex = 12;
            // 
            // TicTacToeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 257);
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.gameResultTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TicTacToeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.gameBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zeroZeroButton;
        private System.Windows.Forms.Button zeroOneButton;
        private System.Windows.Forms.Button zeroTwoButton;
        private System.Windows.Forms.Button oneTwoButton;
        private System.Windows.Forms.Button oneOneButton;
        private System.Windows.Forms.Button oneZeroButton;
        private System.Windows.Forms.Button twoTwoButton;
        private System.Windows.Forms.Button twoOneButton;
        private System.Windows.Forms.Button twoZeroButton;
        private System.Windows.Forms.TextBox gameResultTextBox;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel gameBoard;
    }
}

