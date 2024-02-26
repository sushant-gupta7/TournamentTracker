namespace CreatePrizeForm
{
    partial class createPrizeForm
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
            placeNumberLabel = new Label();
            placeNumberValue = new TextBox();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            priceAmountValue = new TextBox();
            priceAmountLabel = new Label();
            pricePercentageValue = new TextBox();
            pricePercentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI", 17F);
            CreateTeamLabel.ForeColor = SystemColors.MenuHighlight;
            CreateTeamLabel.Location = new Point(38, 9);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(169, 40);
            CreateTeamLabel.TabIndex = 1;
            CreateTeamLabel.Text = "Create Prize";
            CreateTeamLabel.Click += CreateTeamLabel_Click;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 14F);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(38, 74);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(164, 32);
            placeNumberLabel.TabIndex = 2;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Font = new Font("Segoe UI", 14F);
            placeNumberValue.Location = new Point(208, 71);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(159, 39);
            placeNumberValue.TabIndex = 3;
            // 
            // placeNameValue
            // 
            placeNameValue.Font = new Font("Segoe UI", 14F);
            placeNameValue.Location = new Point(208, 135);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(159, 39);
            placeNameValue.TabIndex = 5;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 14F);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(38, 138);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(140, 32);
            placeNameLabel.TabIndex = 4;
            placeNameLabel.Text = "Place Name";
            // 
            // priceAmountValue
            // 
            priceAmountValue.Font = new Font("Segoe UI", 14F);
            priceAmountValue.Location = new Point(208, 197);
            priceAmountValue.Name = "priceAmountValue";
            priceAmountValue.Size = new Size(159, 39);
            priceAmountValue.TabIndex = 7;
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.AutoSize = true;
            priceAmountLabel.Font = new Font("Segoe UI", 14F);
            priceAmountLabel.ForeColor = SystemColors.MenuHighlight;
            priceAmountLabel.Location = new Point(38, 204);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(158, 32);
            priceAmountLabel.TabIndex = 6;
            priceAmountLabel.Text = "Price Amount";
            // 
            // pricePercentageValue
            // 
            pricePercentageValue.Font = new Font("Segoe UI", 14F);
            pricePercentageValue.Location = new Point(208, 330);
            pricePercentageValue.Name = "pricePercentageValue";
            pricePercentageValue.Size = new Size(159, 39);
            pricePercentageValue.TabIndex = 9;
            // 
            // pricePercentageLabel
            // 
            pricePercentageLabel.AutoSize = true;
            pricePercentageLabel.Font = new Font("Segoe UI", 14F);
            pricePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            pricePercentageLabel.Location = new Point(38, 333);
            pricePercentageLabel.Name = "pricePercentageLabel";
            pricePercentageLabel.Size = new Size(92, 32);
            pricePercentageLabel.TabIndex = 8;
            pricePercentageLabel.Text = "Price %";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 14F);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(144, 270);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(66, 32);
            orLabel.TabIndex = 10;
            orLabel.Text = "-OR-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 12F);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(144, 417);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(223, 43);
            createPrizeButton.TabIndex = 11;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // createPrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(562, 502);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(pricePercentageValue);
            Controls.Add(pricePercentageLabel);
            Controls.Add(priceAmountValue);
            Controls.Add(priceAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(CreateTeamLabel);
            Name = "createPrizeForm";
            Text = "Create Prize Form";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTeamLabel;
        private Label placeNumberLabel;
        private TextBox placeNumberValue;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox priceAmountValue;
        private Label priceAmountLabel;
        private TextBox pricePercentageValue;
        private Label pricePercentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}
