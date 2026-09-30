namespace NBA
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnMatchups = new System.Windows.Forms.Button();
            this.btnPhotos = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(692, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "NBA Managment System";
            // 
            // btnTeams
            // 
            this.btnTeams.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeams.Location = new System.Drawing.Point(170, 150);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(201, 67);
            this.btnTeams.TabIndex = 8;
            this.btnTeams.Text = "Teams";
            this.btnTeams.UseVisualStyleBackColor = false;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnMatchups
            // 
            this.btnMatchups.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMatchups.Location = new System.Drawing.Point(170, 261);
            this.btnMatchups.Name = "btnMatchups";
            this.btnMatchups.Size = new System.Drawing.Size(201, 67);
            this.btnMatchups.TabIndex = 9;
            this.btnMatchups.Text = "Matchups";
            this.btnMatchups.UseVisualStyleBackColor = false;
            this.btnMatchups.Click += new System.EventHandler(this.btnMatchups_Click);
            // 
            // btnPhotos
            // 
            this.btnPhotos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPhotos.Location = new System.Drawing.Point(446, 261);
            this.btnPhotos.Name = "btnPhotos";
            this.btnPhotos.Size = new System.Drawing.Size(201, 67);
            this.btnPhotos.TabIndex = 10;
            this.btnPhotos.Text = "Photos";
            this.btnPhotos.UseVisualStyleBackColor = false;
            this.btnPhotos.Click += new System.EventHandler(this.btnPhotos_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlayers.Location = new System.Drawing.Point(446, 150);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(201, 67);
            this.btnPlayers.TabIndex = 11;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = false;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.btnPhotos);
            this.Controls.Add(this.btnMatchups);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "VisitorMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnMatchups;
        private System.Windows.Forms.Button btnPhotos;
        private System.Windows.Forms.Button btnPlayers;
    }
}