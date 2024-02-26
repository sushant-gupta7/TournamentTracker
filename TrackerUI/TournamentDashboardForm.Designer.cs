namespace TournamentDashboardForm
{
    partial class tournamentDashboardForm
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
            loadExistingTournamentDropdown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            tournamentDashboardLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // loadExistingTournamentDropdown
            // 
            loadExistingTournamentDropdown.Font = new Font("Segoe UI", 14F);
            loadExistingTournamentDropdown.FormattingEnabled = true;
            loadExistingTournamentDropdown.Location = new Point(96, 108);
            loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            loadExistingTournamentDropdown.Size = new Size(292, 39);
            loadExistingTournamentDropdown.TabIndex = 12;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 15F);
            loadExistingTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            loadExistingTournamentLabel.Location = new Point(96, 70);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(301, 35);
            loadExistingTournamentLabel.TabIndex = 8;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 17F);
            tournamentDashboardLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentDashboardLabel.Location = new Point(81, 9);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(316, 40);
            tournamentDashboardLabel.TabIndex = 7;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI", 14F);
            loadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            loadTournamentButton.Location = new Point(134, 153);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(231, 44);
            loadTournamentButton.TabIndex = 14;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI", 14F);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(74, 220);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(323, 66);
            createTournamentButton.TabIndex = 15;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // tournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(551, 363);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentDropdown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Name = "tournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox loadExistingTournamentDropdown;
        private Label loadExistingTournamentLabel;
        private Label tournamentDashboardLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}
