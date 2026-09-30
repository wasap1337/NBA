namespace NBA
{
    partial class PlayerDetailForm

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPoints = new System.Windows.Forms.Button();
            this.btnRebounds = new System.Windows.Forms.Button();
            this.btnAssists = new System.Windows.Forms.Button();
            this.btnSteals = new System.Windows.Forms.Button();
            this.btnBlocks = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblCollege = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSeasonPPG = new System.Windows.Forms.Label();
            this.lblSeasonAPG = new System.Windows.Forms.Label();
            this.lblSeasonRPG = new System.Windows.Forms.Label();
            this.lblCareerRPG = new System.Windows.Forms.Label();
            this.lblCareerAPG = new System.Windows.Forms.Label();
            this.lblCareerPPG = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStats
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStats.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStats.Legends.Add(legend2);
            this.chartStats.Location = new System.Drawing.Point(12, 508);
            this.chartStats.Name = "chartStats";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStats.Series.Add(series2);
            this.chartStats.Size = new System.Drawing.Size(908, 221);
            this.chartStats.TabIndex = 0;
            this.chartStats.Text = "chart1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(863, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPoints
            // 
            this.btnPoints.Location = new System.Drawing.Point(80, 430);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(75, 23);
            this.btnPoints.TabIndex = 2;
            this.btnPoints.Text = "POINTS";
            this.btnPoints.UseVisualStyleBackColor = true;
            this.btnPoints.Click += new System.EventHandler(this.btnPoints_Click);
            // 
            // btnRebounds
            // 
            this.btnRebounds.Location = new System.Drawing.Point(260, 430);
            this.btnRebounds.Name = "btnRebounds";
            this.btnRebounds.Size = new System.Drawing.Size(110, 23);
            this.btnRebounds.TabIndex = 3;
            this.btnRebounds.Text = "REBOUNDS";
            this.btnRebounds.UseVisualStyleBackColor = true;
            this.btnRebounds.Click += new System.EventHandler(this.btnRebounds_Click);
            // 
            // btnAssists
            // 
            this.btnAssists.Location = new System.Drawing.Point(477, 430);
            this.btnAssists.Name = "btnAssists";
            this.btnAssists.Size = new System.Drawing.Size(75, 23);
            this.btnAssists.TabIndex = 4;
            this.btnAssists.Text = "ASISTS";
            this.btnAssists.UseVisualStyleBackColor = true;
            this.btnAssists.Click += new System.EventHandler(this.btnAssists_Click);
            // 
            // btnSteals
            // 
            this.btnSteals.Location = new System.Drawing.Point(636, 430);
            this.btnSteals.Name = "btnSteals";
            this.btnSteals.Size = new System.Drawing.Size(75, 23);
            this.btnSteals.TabIndex = 5;
            this.btnSteals.Text = "STEALS";
            this.btnSteals.UseVisualStyleBackColor = true;
            this.btnSteals.Click += new System.EventHandler(this.btnSteals_Click);
            // 
            // btnBlocks
            // 
            this.btnBlocks.Location = new System.Drawing.Point(817, 430);
            this.btnBlocks.Name = "btnBlocks";
            this.btnBlocks.Size = new System.Drawing.Size(75, 23);
            this.btnBlocks.TabIndex = 6;
            this.btnBlocks.Text = "BLOCKS";
            this.btnBlocks.UseVisualStyleBackColor = true;
            this.btnBlocks.Click += new System.EventHandler(this.btnBlocks_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(420, 477);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(59, 16);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Average";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "2017/08/31 - 2017/09/15";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerName.Location = new System.Drawing.Point(52, 43);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(20, 16);
            this.lblPlayerName.TabIndex = 9;
            this.lblPlayerName.Text = "pl";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(52, 78);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(32, 16);
            this.lblNumber.TabIndex = 10;
            this.lblNumber.Text = "num";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(230, 78);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(37, 16);
            this.lblTeam.TabIndex = 11;
            this.lblTeam.Text = "team";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(215, 126);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(34, 16);
            this.lblBirthDate.TabIndex = 12;
            this.lblBirthDate.Text = "date";
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Location = new System.Drawing.Point(215, 180);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(52, 16);
            this.lblCollege.TabIndex = 13;
            this.lblCollege.Text = "college";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(501, 135);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(29, 16);
            this.lblExperience.TabIndex = 14;
            this.lblExperience.Text = "opit";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(501, 180);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(21, 16);
            this.lblSalary.TabIndex = 15;
            this.lblSalary.Text = "zp";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(131, 78);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(24, 16);
            this.lblHeight.TabIndex = 16;
            this.lblHeight.Text = "tall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "born";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "college";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(365, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(356, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Experience";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(619, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "2016-2017 Season";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(619, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "PPG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(704, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "APG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(791, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "RPG";
            // 
            // lblSeasonPPG
            // 
            this.lblSeasonPPG.AutoSize = true;
            this.lblSeasonPPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeasonPPG.Location = new System.Drawing.Point(619, 156);
            this.lblSeasonPPG.Name = "lblSeasonPPG";
            this.lblSeasonPPG.Size = new System.Drawing.Size(35, 16);
            this.lblSeasonPPG.TabIndex = 25;
            this.lblSeasonPPG.Text = "PPG";
            // 
            // lblSeasonAPG
            // 
            this.lblSeasonAPG.AutoSize = true;
            this.lblSeasonAPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeasonAPG.Location = new System.Drawing.Point(704, 156);
            this.lblSeasonAPG.Name = "lblSeasonAPG";
            this.lblSeasonAPG.Size = new System.Drawing.Size(35, 16);
            this.lblSeasonAPG.TabIndex = 26;
            this.lblSeasonAPG.Text = "PPG";
            // 
            // lblSeasonRPG
            // 
            this.lblSeasonRPG.AutoSize = true;
            this.lblSeasonRPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblSeasonRPG.Location = new System.Drawing.Point(792, 156);
            this.lblSeasonRPG.Name = "lblSeasonRPG";
            this.lblSeasonRPG.Size = new System.Drawing.Size(35, 16);
            this.lblSeasonRPG.TabIndex = 27;
            this.lblSeasonRPG.Text = "PPG";
            // 
            // lblCareerRPG
            // 
            this.lblCareerRPG.AutoSize = true;
            this.lblCareerRPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblCareerRPG.Location = new System.Drawing.Point(789, 289);
            this.lblCareerRPG.Name = "lblCareerRPG";
            this.lblCareerRPG.Size = new System.Drawing.Size(35, 16);
            this.lblCareerRPG.TabIndex = 33;
            this.lblCareerRPG.Text = "PPG";
            // 
            // lblCareerAPG
            // 
            this.lblCareerAPG.AutoSize = true;
            this.lblCareerAPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCareerAPG.Location = new System.Drawing.Point(701, 289);
            this.lblCareerAPG.Name = "lblCareerAPG";
            this.lblCareerAPG.Size = new System.Drawing.Size(35, 16);
            this.lblCareerAPG.TabIndex = 32;
            this.lblCareerAPG.Text = "PPG";
            // 
            // lblCareerPPG
            // 
            this.lblCareerPPG.AutoSize = true;
            this.lblCareerPPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCareerPPG.Location = new System.Drawing.Point(616, 289);
            this.lblCareerPPG.Name = "lblCareerPPG";
            this.lblCareerPPG.Size = new System.Drawing.Size(35, 16);
            this.lblCareerPPG.TabIndex = 31;
            this.lblCareerPPG.Text = "PPG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(788, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "RPG";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(701, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "APG";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(616, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "PPG";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(616, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Career";
            // 
            // PlayerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 729);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblCareerRPG);
            this.Controls.Add(this.lblCareerAPG);
            this.Controls.Add(this.lblCareerPPG);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblSeasonRPG);
            this.Controls.Add(this.lblSeasonAPG);
            this.Controls.Add(this.lblSeasonPPG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblCollege);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnBlocks);
            this.Controls.Add(this.btnSteals);
            this.Controls.Add(this.btnAssists);
            this.Controls.Add(this.btnRebounds);
            this.Controls.Add(this.btnPoints);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chartStats);
            this.Name = "PlayerDetailForm";
            this.Text = "PlayerDetailForm";
            this.Load += new System.EventHandler(this.PlayerDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Button btnRebounds;
        private System.Windows.Forms.Button btnAssists;
        private System.Windows.Forms.Button btnSteals;
        private System.Windows.Forms.Button btnBlocks;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblCollege;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSeasonPPG;
        private System.Windows.Forms.Label lblSeasonAPG;
        private System.Windows.Forms.Label lblSeasonRPG;
        private System.Windows.Forms.Label lblCareerRPG;
        private System.Windows.Forms.Label lblCareerAPG;
        private System.Windows.Forms.Label lblCareerPPG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}