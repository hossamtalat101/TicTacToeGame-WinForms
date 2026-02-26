namespace TicTacToeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMainTitle = new Label();
            btnRestart = new Button();
            lblTurnTitle = new Label();
            lblStatus = new Label();
            lblWinnerTitle = new Label();
            lblWinner = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTopMiddle = new Button();
            btnTopRight = new Button();
            btnMiddleLeft = new Button();
            btnCenter = new Button();
            btnMiddleRight = new Button();
            btnBottomRight = new Button();
            btnBottomMiddle = new Button();
            btnBottomLeft = new Button();
            btnTopLeft = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainTitle.ForeColor = Color.Red;
            lblMainTitle.Location = new Point(218, 9);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(354, 54);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "Tic-Tac-Toe Game";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Lime;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.Black;
            btnRestart.Location = new Point(26, 354);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(194, 60);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart Game";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblTurnTitle
            // 
            lblTurnTitle.AutoSize = true;
            lblTurnTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTurnTitle.ForeColor = Color.FromArgb(255, 128, 0);
            lblTurnTitle.Location = new Point(26, 94);
            lblTurnTitle.Name = "lblTurnTitle";
            lblTurnTitle.Size = new Size(76, 38);
            lblTurnTitle.TabIndex = 3;
            lblTurnTitle.Text = "Turn";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblStatus.ForeColor = Color.SpringGreen;
            lblStatus.Location = new Point(26, 142);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(98, 38);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Player";
            // 
            // lblWinnerTitle
            // 
            lblWinnerTitle.AutoSize = true;
            lblWinnerTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblWinnerTitle.ForeColor = Color.FromArgb(255, 128, 0);
            lblWinnerTitle.Location = new Point(26, 209);
            lblWinnerTitle.Name = "lblWinnerTitle";
            lblWinnerTitle.Size = new Size(113, 38);
            lblWinnerTitle.TabIndex = 5;
            lblWinnerTitle.Text = "Winner";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblWinner.ForeColor = Color.Lime;
            lblWinner.Location = new Point(26, 271);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(163, 38);
            lblWinner.TabIndex = 6;
            lblWinner.Text = "In Progress";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnTopMiddle);
            panel1.Controls.Add(btnTopRight);
            panel1.Controls.Add(btnMiddleLeft);
            panel1.Controls.Add(btnCenter);
            panel1.Controls.Add(btnMiddleRight);
            panel1.Controls.Add(btnBottomRight);
            panel1.Controls.Add(btnBottomMiddle);
            panel1.Controls.Add(btnBottomLeft);
            panel1.Controls.Add(btnTopLeft);
            panel1.Location = new Point(373, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 320);
            panel1.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(255, 128, 0);
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(295, 10);
            label4.Name = "label4";
            label4.Size = new Size(8, 300);
            label4.TabIndex = 27;
            label4.Text = "Game Over";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 128, 0);
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(146, 9);
            label3.Name = "label3";
            label3.Size = new Size(8, 300);
            label3.TabIndex = 26;
            label3.Text = "Game Over";
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 128, 0);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(-1, 207);
            label2.Name = "label2";
            label2.Size = new Size(450, 8);
            label2.TabIndex = 25;
            label2.Text = "Game Over";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 110);
            label1.Name = "label1";
            label1.Size = new Size(450, 8);
            label1.TabIndex = 8;
            label1.Text = "Game Over";
            // 
            // btnTopMiddle
            // 
            btnTopMiddle.BackColor = Color.Black;
            btnTopMiddle.FlatStyle = FlatStyle.Flat;
            btnTopMiddle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnTopMiddle.ForeColor = Color.Tomato;
            btnTopMiddle.Location = new Point(173, 32);
            btnTopMiddle.Name = "btnTopMiddle";
            btnTopMiddle.Size = new Size(112, 64);
            btnTopMiddle.TabIndex = 24;
            btnTopMiddle.Tag = "2";
            btnTopMiddle.Text = "?";
            btnTopMiddle.UseVisualStyleBackColor = false;
            btnTopMiddle.Click += btn_Click;
            // 
            // btnTopRight
            // 
            btnTopRight.BackColor = Color.Black;
            btnTopRight.FlatStyle = FlatStyle.Flat;
            btnTopRight.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnTopRight.ForeColor = Color.Tomato;
            btnTopRight.Location = new Point(314, 32);
            btnTopRight.Name = "btnTopRight";
            btnTopRight.Size = new Size(112, 64);
            btnTopRight.TabIndex = 23;
            btnTopRight.Tag = "3";
            btnTopRight.Text = "?";
            btnTopRight.UseVisualStyleBackColor = false;
            btnTopRight.Click += btn_Click;
            // 
            // btnMiddleLeft
            // 
            btnMiddleLeft.BackColor = Color.Black;
            btnMiddleLeft.FlatStyle = FlatStyle.Flat;
            btnMiddleLeft.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnMiddleLeft.ForeColor = Color.Tomato;
            btnMiddleLeft.Location = new Point(20, 129);
            btnMiddleLeft.Name = "btnMiddleLeft";
            btnMiddleLeft.Size = new Size(112, 64);
            btnMiddleLeft.TabIndex = 22;
            btnMiddleLeft.Tag = "4";
            btnMiddleLeft.Text = "?";
            btnMiddleLeft.UseVisualStyleBackColor = false;
            btnMiddleLeft.Click += btn_Click;
            // 
            // btnCenter
            // 
            btnCenter.BackColor = Color.Black;
            btnCenter.FlatStyle = FlatStyle.Flat;
            btnCenter.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnCenter.ForeColor = Color.Tomato;
            btnCenter.Location = new Point(173, 129);
            btnCenter.Name = "btnCenter";
            btnCenter.Size = new Size(112, 64);
            btnCenter.TabIndex = 21;
            btnCenter.Tag = "5";
            btnCenter.Text = "?";
            btnCenter.UseVisualStyleBackColor = false;
            btnCenter.Click += btn_Click;
            // 
            // btnMiddleRight
            // 
            btnMiddleRight.BackColor = Color.Black;
            btnMiddleRight.FlatStyle = FlatStyle.Flat;
            btnMiddleRight.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnMiddleRight.ForeColor = Color.Tomato;
            btnMiddleRight.Location = new Point(314, 133);
            btnMiddleRight.Name = "btnMiddleRight";
            btnMiddleRight.Size = new Size(112, 64);
            btnMiddleRight.TabIndex = 20;
            btnMiddleRight.Tag = "6";
            btnMiddleRight.Text = "?";
            btnMiddleRight.UseVisualStyleBackColor = false;
            btnMiddleRight.Click += btn_Click;
            // 
            // btnBottomRight
            // 
            btnBottomRight.BackColor = Color.Black;
            btnBottomRight.FlatStyle = FlatStyle.Flat;
            btnBottomRight.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnBottomRight.ForeColor = Color.Tomato;
            btnBottomRight.Location = new Point(314, 228);
            btnBottomRight.Name = "btnBottomRight";
            btnBottomRight.Size = new Size(112, 64);
            btnBottomRight.TabIndex = 19;
            btnBottomRight.Tag = "9";
            btnBottomRight.Text = "?";
            btnBottomRight.UseVisualStyleBackColor = false;
            btnBottomRight.Click += btn_Click;
            // 
            // btnBottomMiddle
            // 
            btnBottomMiddle.BackColor = Color.Black;
            btnBottomMiddle.FlatStyle = FlatStyle.Flat;
            btnBottomMiddle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnBottomMiddle.ForeColor = Color.Tomato;
            btnBottomMiddle.Location = new Point(173, 228);
            btnBottomMiddle.Name = "btnBottomMiddle";
            btnBottomMiddle.Size = new Size(112, 64);
            btnBottomMiddle.TabIndex = 18;
            btnBottomMiddle.Tag = "8";
            btnBottomMiddle.Text = "?";
            btnBottomMiddle.UseVisualStyleBackColor = false;
            btnBottomMiddle.Click += btn_Click;
            // 
            // btnBottomLeft
            // 
            btnBottomLeft.BackColor = Color.Black;
            btnBottomLeft.FlatStyle = FlatStyle.Flat;
            btnBottomLeft.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnBottomLeft.ForeColor = Color.Tomato;
            btnBottomLeft.Location = new Point(20, 228);
            btnBottomLeft.Name = "btnBottomLeft";
            btnBottomLeft.Size = new Size(112, 64);
            btnBottomLeft.TabIndex = 17;
            btnBottomLeft.Tag = "7";
            btnBottomLeft.Text = "?";
            btnBottomLeft.UseVisualStyleBackColor = false;
            btnBottomLeft.Click += btn_Click;
            // 
            // btnTopLeft
            // 
            btnTopLeft.BackColor = Color.Black;
            btnTopLeft.FlatStyle = FlatStyle.Flat;
            btnTopLeft.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btnTopLeft.ForeColor = Color.Tomato;
            btnTopLeft.Location = new Point(20, 32);
            btnTopLeft.Name = "btnTopLeft";
            btnTopLeft.Size = new Size(112, 64);
            btnTopLeft.TabIndex = 16;
            btnTopLeft.Tag = "1";
            btnTopLeft.Text = "?";
            btnTopLeft.UseVisualStyleBackColor = false;
            btnTopLeft.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(859, 450);
            Controls.Add(panel1);
            Controls.Add(lblWinner);
            Controls.Add(lblWinnerTitle);
            Controls.Add(lblStatus);
            Controls.Add(lblTurnTitle);
            Controls.Add(btnRestart);
            Controls.Add(lblMainTitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe Game";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMainTitle;
        private Button btnRestart;
        private Label lblTurnTitle;
        private Label lblStatus;
        private Label lblWinnerTitle;
        private Label lblWinner;
        private Panel panel1;
        private Button btnTopMiddle;
        private Button btnTopRight;
        private Button btnMiddleLeft;
        private Button btnCenter;
        private Button btnMiddleRight;
        private Button btnBottomRight;
        private Button btnBottomMiddle;
        private Button btnBottomLeft;
        private Button btnTopLeft;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
