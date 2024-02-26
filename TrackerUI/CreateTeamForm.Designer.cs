namespace CreateTeamForm
{
    partial class CreateTeamForm
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
            CreateTeamLabel = new Label();
            SelectedTeamMemberlabel = new Label();
            TeamNameLabel = new Label();
            AddMemberButton = new Button();
            AddNewMemberGroupBox = new GroupBox();
            teamNametTextbox = new TextBox();
            SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI", 15F);
            CreateTeamLabel.ForeColor = SystemColors.MenuHighlight;
            CreateTeamLabel.Location = new Point(57, 19);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(152, 35);
            CreateTeamLabel.TabIndex = 0;
            CreateTeamLabel.Text = "Create Team";
            CreateTeamLabel.Click += label1_Click;
            // 
            // SelectedTeamMemberlabel
            // 
            SelectedTeamMemberlabel.AutoSize = true;
            SelectedTeamMemberlabel.Font = new Font("Segoe UI", 15F);
            SelectedTeamMemberlabel.ForeColor = SystemColors.MenuHighlight;
            SelectedTeamMemberlabel.Location = new Point(65, 167);
            SelectedTeamMemberlabel.Name = "SelectedTeamMemberlabel";
            SelectedTeamMemberlabel.Size = new Size(275, 35);
            SelectedTeamMemberlabel.TabIndex = 1;
            SelectedTeamMemberlabel.Text = "Selected Team Member";
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 15F);
            TeamNameLabel.ForeColor = SystemColors.MenuHighlight;
            TeamNameLabel.Location = new Point(61, 76);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(148, 35);
            TeamNameLabel.TabIndex = 2;
            TeamNameLabel.Text = "Team Name";
            // 
            // AddMemberButton
            // 
            AddMemberButton.Font = new Font("Segoe UI", 12F);
            AddMemberButton.ForeColor = SystemColors.MenuHighlight;
            AddMemberButton.Location = new Point(61, 262);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(186, 43);
            AddMemberButton.TabIndex = 3;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // AddNewMemberGroupBox
            // 
            AddNewMemberGroupBox.Location = new Point(61, 332);
            AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            AddNewMemberGroupBox.Size = new Size(250, 197);
            AddNewMemberGroupBox.TabIndex = 4;
            AddNewMemberGroupBox.TabStop = false;
            AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // teamNametTextbox
            // 
            teamNametTextbox.Location = new Point(65, 125);
            teamNametTextbox.Name = "teamNametTextbox";
            teamNametTextbox.Size = new Size(246, 27);
            teamNametTextbox.TabIndex = 5;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 541);
            Controls.Add(teamNametTextbox);
            Controls.Add(AddNewMemberGroupBox);
            Controls.Add(AddMemberButton);
            Controls.Add(TeamNameLabel);
            Controls.Add(SelectedTeamMemberlabel);
            Controls.Add(CreateTeamLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTeamLabel;
        private Label SelectedTeamMemberlabel;
        private Label TeamNameLabel;
        private Button AddMemberButton;
        private GroupBox AddNewMemberGroupBox;
        private TextBox teamNametTextbox;
    }
}
