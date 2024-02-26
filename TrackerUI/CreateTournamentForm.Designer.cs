namespace CreateTournamentForm
{
    partial class CreateTournamentForm
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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TournamentNameTextbox = new System.Windows.Forms.TextBox();
            this.EntryFeelabel = new System.Windows.Forms.Label();
            this.TournamentPLayersLabel = new System.Windows.Forms.TextBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teamsLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayersScoreButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentLabel.Location = new System.Drawing.Point(23, 9);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(253, 38);
            this.createTournamentLabel.TabIndex = 0;
            this.createTournamentLabel.Text = "Create Tournament";
            this.createTournamentLabel.Click += new System.EventHandler(this.createTournamentLabel_Click);
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(23, 50);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(242, 38);
            this.TournamentNameLabel.TabIndex = 1;
            this.TournamentNameLabel.Text = "Tournament name";
            this.TournamentNameLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // TournamentNameTextbox
            // 
            this.TournamentNameTextbox.Location = new System.Drawing.Point(30, 91);
            this.TournamentNameTextbox.Name = "TournamentNameTextbox";
            this.TournamentNameTextbox.Size = new System.Drawing.Size(235, 43);
            this.TournamentNameTextbox.TabIndex = 2;
            // 
            // EntryFeelabel
            // 
            this.EntryFeelabel.AutoSize = true;
            this.EntryFeelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeelabel.Location = new System.Drawing.Point(23, 154);
            this.EntryFeelabel.Name = "EntryFeelabel";
            this.EntryFeelabel.Size = new System.Drawing.Size(132, 38);
            this.EntryFeelabel.TabIndex = 3;
            this.EntryFeelabel.Text = "Entry Fee";
            this.EntryFeelabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TournamentPLayersLabel
            // 
            this.TournamentPLayersLabel.Location = new System.Drawing.Point(169, 154);
            this.TournamentPLayersLabel.Name = "TournamentPLayersLabel";
            this.TournamentPLayersLabel.Size = new System.Drawing.Size(130, 43);
            this.TournamentPLayersLabel.TabIndex = 4;
            this.TournamentPLayersLabel.Text = "0";
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(23, 218);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(164, 38);
            this.SelectTeamLabel.TabIndex = 5;
            this.SelectTeamLabel.Text = "Select Team";
            this.SelectTeamLabel.Click += new System.EventHandler(this.RoundLabel_Click);
            // 
            // SelectTeamDropdown
            // 
            this.SelectTeamDropdown.FormattingEnabled = true;
            this.SelectTeamDropdown.Location = new System.Drawing.Point(30, 282);
            this.SelectTeamDropdown.Name = "SelectTeamDropdown";
            this.SelectTeamDropdown.Size = new System.Drawing.Size(315, 45);
            this.SelectTeamDropdown.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(217, 218);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 38);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "create new";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(107, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Team";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(97, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Create Prize";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 37;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(417, 50);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(335, 189);
            this.tournamentPlayersListBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(475, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 11;
            // 
            // teamsLabel
            // 
            this.teamsLabel.AutoSize = true;
            this.teamsLabel.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.teamsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamsLabel.Location = new System.Drawing.Point(410, 9);
            this.teamsLabel.Name = "teamsLabel";
            this.teamsLabel.Size = new System.Drawing.Size(156, 30);
            this.teamsLabel.TabIndex = 12;
            this.teamsLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayersScoreButton
            // 
            this.deleteSelectedPlayersScoreButton.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.deleteSelectedPlayersScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayersScoreButton.Location = new System.Drawing.Point(775, 127);
            this.deleteSelectedPlayersScoreButton.Name = "deleteSelectedPlayersScoreButton";
            this.deleteSelectedPlayersScoreButton.Size = new System.Drawing.Size(170, 39);
            this.deleteSelectedPlayersScoreButton.TabIndex = 13;
            this.deleteSelectedPlayersScoreButton.Text = "Delete Selected";
            this.deleteSelectedPlayersScoreButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(775, 379);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(170, 39);
            this.deleteSelectedPrizeButton.TabIndex = 17;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(412, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 16;
            this.label2.Text = "Teams / Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(475, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 38);
            this.label3.TabIndex = 15;
            // 
            // prizesListBox
            // 
            this.prizesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(417, 283);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(335, 189);
            this.prizesListBox.TabIndex = 14;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12.2F);
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(359, 490);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(209, 39);
            this.CreateTournamentButton.TabIndex = 18;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 540);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayersScoreButton);
            this.Controls.Add(this.teamsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SelectTeamDropdown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.TournamentPLayersLabel);
            this.Controls.Add(this.EntryFeelabel);
            this.Controls.Add(this.TournamentNameTextbox);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox TournamentNameTextbox;
        private System.Windows.Forms.Label EntryFeelabel;
        private System.Windows.Forms.TextBox TournamentPLayersLabel;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropdown;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label teamsLabel;
        private System.Windows.Forms.Button deleteSelectedPlayersScoreButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}

