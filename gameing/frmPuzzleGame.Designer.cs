
namespace gameing
{
    partial class frmPuzzleGame
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
            this.btnPause = new System.Windows.Forms.Button();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(807, 495);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(115, 52);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMovesMade.Location = new System.Drawing.Point(21, 543);
            this.lblMovesMade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(148, 24);
            this.lblMovesMade.TabIndex = 9;
            this.lblMovesMade.Text = "Moves Made : ";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuit.Location = new System.Drawing.Point(969, 495);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(115, 52);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::gameing.Properties.Resources.Orginal;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Location = new System.Drawing.Point(652, -1);
            this.gbOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Padding = new System.Windows.Forms.Padding(4);
            this.gbOriginal.Size = new System.Drawing.Size(420, 321);
            this.gbOriginal.TabIndex = 5;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original";
            this.gbOriginal.Enter += new System.EventHandler(this.gbOriginal_Enter);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.White;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShuffle.Location = new System.Drawing.Point(648, 495);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(115, 52);
            this.btnShuffle.TabIndex = 8;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx5);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Location = new System.Drawing.Point(16, 6);
            this.gbPuzzleBox.Margin = new System.Windows.Forms.Padding(4);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Padding = new System.Windows.Forms.Padding(4);
            this.gbPuzzleBox.Size = new System.Drawing.Size(569, 533);
            this.gbPuzzleBox.TabIndex = 6;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "PuzzleBox";
            this.gbPuzzleBox.Enter += new System.EventHandler(this.gbPuzzleBox_Enter);
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(23, 28);
            this.pbx1.Margin = new System.Windows.Forms.Padding(4);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(173, 160);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(199, 28);
            this.pbx2.Margin = new System.Windows.Forms.Padding(4);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(173, 160);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.Location = new System.Drawing.Point(375, 28);
            this.pbx3.Margin = new System.Windows.Forms.Padding(4);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(173, 160);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.Location = new System.Drawing.Point(23, 191);
            this.pbx4.Margin = new System.Windows.Forms.Padding(4);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(173, 160);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.Location = new System.Drawing.Point(199, 191);
            this.pbx5.Margin = new System.Windows.Forms.Padding(4);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(173, 160);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.Location = new System.Drawing.Point(375, 191);
            this.pbx6.Margin = new System.Windows.Forms.Padding(4);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(173, 160);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.Location = new System.Drawing.Point(23, 353);
            this.pbx7.Margin = new System.Windows.Forms.Padding(4);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(173, 160);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.Location = new System.Drawing.Point(199, 353);
            this.pbx8.Margin = new System.Windows.Forms.Padding(4);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(173, 160);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx9
            // 
            this.pbx9.Location = new System.Drawing.Point(375, 353);
            this.pbx9.Margin = new System.Windows.Forms.Padding(4);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(173, 160);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.tmrTimeElapse_Tick);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(709, 361);
            this.lblTimeElapsed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(332, 98);
            this.lblTimeElapsed.TabIndex = 3;
            this.lblTimeElapsed.Text = "00:00:00";
            this.lblTimeElapsed.Click += new System.EventHandler(this.lblTimeElapsed_Click);
            // 
            // frmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 622);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.gbPuzzleBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "puzzel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPermissionBeforeQuite);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private System.Windows.Forms.Label lblTimeElapsed;
    }
}