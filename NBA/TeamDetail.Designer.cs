namespace NBA
{
    partial class TeamDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamDetail));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTeamLogo = new System.Windows.Forms.PictureBox();
            this.lblTeamHeader = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvRoster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(756, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "NBA Managment System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbTeamLogo
            // 
            this.pbTeamLogo.Location = new System.Drawing.Point(24, 138);
            this.pbTeamLogo.Name = "pbTeamLogo";
            this.pbTeamLogo.Size = new System.Drawing.Size(50, 50);
            this.pbTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeamLogo.TabIndex = 10;
            this.pbTeamLogo.TabStop = false;
            // 
            // lblTeamHeader
            // 
            this.lblTeamHeader.AutoSize = true;
            this.lblTeamHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTeamHeader.Location = new System.Drawing.Point(100, 163);
            this.lblTeamHeader.Name = "lblTeamHeader";
            this.lblTeamHeader.Size = new System.Drawing.Size(64, 25);
            this.lblTeamHeader.TabIndex = 11;
            this.lblTeamHeader.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Roaster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRoster_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Matchup";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnMatchup_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Lineup";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvRoster
            // 
            this.dgvRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoster.Location = new System.Drawing.Point(12, 249);
            this.dgvRoster.Name = "dgvRoster";
            this.dgvRoster.RowHeadersWidth = 51;
            this.dgvRoster.RowTemplate.Height = 24;
            this.dgvRoster.Size = new System.Drawing.Size(834, 301);
            this.dgvRoster.TabIndex = 15;
            // 
            // TeamDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 562);
            this.Controls.Add(this.dgvRoster);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTeamHeader);
            this.Controls.Add(this.pbTeamLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "TeamDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamDetail_FormClosing);
            this.Load += new System.EventHandler(this.TeamDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbTeamLogo;
        private System.Windows.Forms.Label lblTeamHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvRoster;
    }
}