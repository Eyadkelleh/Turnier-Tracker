namespace TrackerUI
{
    partial class TournamentDashbourdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashbourdForm));
            this.TournamentNAmeLabel = new System.Windows.Forms.Label();
            this.loadExostingLabel = new System.Windows.Forms.Label();
            this.loadExitingTournametDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentNAmeLabel
            // 
            this.TournamentNAmeLabel.AutoSize = true;
            this.TournamentNAmeLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNAmeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNAmeLabel.Location = new System.Drawing.Point(137, 9);
            this.TournamentNAmeLabel.Name = "TournamentNAmeLabel";
            this.TournamentNAmeLabel.Size = new System.Drawing.Size(305, 40);
            this.TournamentNAmeLabel.TabIndex = 14;
            this.TournamentNAmeLabel.Text = "Tournament Dashbourd";
            // 
            // loadExostingLabel
            // 
            this.loadExostingLabel.AutoSize = true;
            this.loadExostingLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExostingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadExostingLabel.Location = new System.Drawing.Point(125, 83);
            this.loadExostingLabel.Name = "loadExostingLabel";
            this.loadExostingLabel.Size = new System.Drawing.Size(329, 40);
            this.loadExostingLabel.TabIndex = 15;
            this.loadExostingLabel.Text = "Load Existing Tournament";
            // 
            // loadExitingTournametDropDown
            // 
            this.loadExitingTournametDropDown.FormattingEnabled = true;
            this.loadExitingTournametDropDown.Location = new System.Drawing.Point(116, 154);
            this.loadExitingTournametDropDown.Name = "loadExitingTournametDropDown";
            this.loadExitingTournametDropDown.Size = new System.Drawing.Size(347, 38);
            this.loadExitingTournametDropDown.TabIndex = 16;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.Color.White;
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournamentButton.Location = new System.Drawing.Point(188, 223);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(202, 48);
            this.loadTournamentButton.TabIndex = 24;
            this.loadTournamentButton.Text = "Load Tournamet";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.BackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(160, 298);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(259, 82);
            this.CreateTournamentButton.TabIndex = 25;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashbourdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 416);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExitingTournametDropDown);
            this.Controls.Add(this.loadExostingLabel);
            this.Controls.Add(this.TournamentNAmeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashbourdForm";
            this.Text = "Tournament Dashbourd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentNAmeLabel;
        private System.Windows.Forms.Label loadExostingLabel;
        private System.Windows.Forms.ComboBox loadExitingTournametDropDown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}