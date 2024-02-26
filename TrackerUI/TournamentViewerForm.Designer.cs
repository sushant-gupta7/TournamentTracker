namespace TrackerUI
{
    partial class TournamentViewerForm
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
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 24.2F);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(3, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(238, 55);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 24.2F);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(237, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(166, 55);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(12, 70);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += label1_Click;
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(121, 67);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(180, 45);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += roundDropDown_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 13F);
            unplayedOnlyCheckbox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckbox.Location = new Point(121, 131);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(178, 34);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckbox.CheckedChanged += unplayedOnlyCheckbox_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 37;
            matchupListBox.Location = new Point(16, 179);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(299, 261);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.ForeColor = SystemColors.MenuHighlight;
            teamOneName.Location = new Point(321, 179);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(165, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(324, 237);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(82, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(412, 234);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(81, 43);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(412, 390);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(81, 43);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoScoreLabel.Location = new Point(321, 396);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(82, 37);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(321, 336);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(165, 37);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(376, 289);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(48, 37);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "VS";
            versusLabel.Click += label1_Click_1;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(545, 281);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(125, 53);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += button1_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(721, 471);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
