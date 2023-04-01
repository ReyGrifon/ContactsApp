namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            GithubLabel = new Label();
            EmailTextLabel = new Label();
            EmailLabel = new Label();
            AuthorTextLabel = new Label();
            AuthorLabel = new Label();
            VersionLabel = new Label();
            ContactNameLabel = new Label();
            LicenseTextBox = new TextBox();
            LicenseIconTextLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ClosePanel = new Panel();
            CloseFormButton = new Button();
            InfoPanel = new Panel();
            GithubLinkLabel = new LinkLabel();
            IconsLinkLabel = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            ClosePanel.SuspendLayout();
            InfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GithubLabel
            // 
            GithubLabel.AutoSize = true;
            GithubLabel.Location = new Point(9, 118);
            GithubLabel.Margin = new Padding(3, 10, 3, 0);
            GithubLabel.Name = "GithubLabel";
            GithubLabel.Size = new Size(46, 15);
            GithubLabel.TabIndex = 14;
            GithubLabel.Text = "Github:";
            // 
            // EmailTextLabel
            // 
            EmailTextLabel.AutoSize = true;
            EmailTextLabel.Location = new Point(66, 93);
            EmailTextLabel.Margin = new Padding(3, 10, 3, 0);
            EmailTextLabel.Name = "EmailTextLabel";
            EmailTextLabel.Size = new Size(134, 15);
            EmailTextLabel.TabIndex = 13;
            EmailTextLabel.Text = "sergeypchelnik@mail.ru";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(9, 93);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 12;
            EmailLabel.Text = "E-mail:";
            // 
            // AuthorTextLabel
            // 
            AuthorTextLabel.AutoSize = true;
            AuthorTextLabel.Location = new Point(66, 68);
            AuthorTextLabel.Margin = new Padding(3, 10, 3, 0);
            AuthorTextLabel.Name = "AuthorTextLabel";
            AuthorTextLabel.Size = new Size(90, 15);
            AuthorTextLabel.TabIndex = 11;
            AuthorTextLabel.Text = "Sergey Pchelnik";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(9, 68);
            AuthorLabel.Margin = new Padding(3, 10, 3, 0);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(47, 15);
            AuthorLabel.TabIndex = 10;
            AuthorLabel.Text = "Author:";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(9, 40);
            VersionLabel.Margin = new Padding(3, 5, 3, 0);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(31, 15);
            VersionLabel.TabIndex = 9;
            VersionLabel.Text = "v 1.0";
            // 
            // ContactNameLabel
            // 
            ContactNameLabel.AutoSize = true;
            ContactNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ContactNameLabel.Location = new Point(9, 5);
            ContactNameLabel.Name = "ContactNameLabel";
            ContactNameLabel.Size = new Size(147, 30);
            ContactNameLabel.TabIndex = 8;
            ContactNameLabel.Text = "ContactsApp";
            // 
            // LicenseTextBox
            // 
            LicenseTextBox.AcceptsTab = true;
            LicenseTextBox.Location = new Point(9, 148);
            LicenseTextBox.Multiline = true;
            LicenseTextBox.Name = "LicenseTextBox";
            LicenseTextBox.ScrollBars = ScrollBars.Vertical;
            LicenseTextBox.Size = new Size(487, 171);
            LicenseTextBox.TabIndex = 16;
            LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            LicenseTextBox.KeyPress += LicenseTextBox_KeyPress;
            // 
            // LicenseIconTextLabel
            // 
            LicenseIconTextLabel.AutoSize = true;
            LicenseIconTextLabel.Location = new Point(6, 327);
            LicenseIconTextLabel.Margin = new Padding(0, 5, 2, 5);
            LicenseIconTextLabel.Name = "LicenseIconTextLabel";
            LicenseIconTextLabel.Size = new Size(220, 15);
            LicenseIconTextLabel.TabIndex = 17;
            LicenseIconTextLabel.Text = " All used images are downoloaded  from";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ClosePanel, 0, 1);
            tableLayoutPanel1.Controls.Add(InfoPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(511, 400);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // ClosePanel
            // 
            ClosePanel.BackColor = Color.WhiteSmoke;
            ClosePanel.Controls.Add(CloseFormButton);
            ClosePanel.Dock = DockStyle.Fill;
            ClosePanel.Location = new Point(3, 356);
            ClosePanel.Name = "ClosePanel";
            ClosePanel.Size = new Size(505, 41);
            ClosePanel.TabIndex = 0;
            // 
            // CloseFormButton
            // 
            CloseFormButton.Location = new Point(421, 9);
            CloseFormButton.Name = "CloseFormButton";
            CloseFormButton.Size = new Size(75, 23);
            CloseFormButton.TabIndex = 19;
            CloseFormButton.Text = "OK";
            CloseFormButton.UseVisualStyleBackColor = true;
            CloseFormButton.Click += CloseFormButton_Click;
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(GithubLinkLabel);
            InfoPanel.Controls.Add(IconsLinkLabel);
            InfoPanel.Controls.Add(LicenseTextBox);
            InfoPanel.Controls.Add(LicenseIconTextLabel);
            InfoPanel.Controls.Add(AuthorTextLabel);
            InfoPanel.Controls.Add(GithubLabel);
            InfoPanel.Controls.Add(ContactNameLabel);
            InfoPanel.Controls.Add(EmailTextLabel);
            InfoPanel.Controls.Add(VersionLabel);
            InfoPanel.Controls.Add(EmailLabel);
            InfoPanel.Controls.Add(AuthorLabel);
            InfoPanel.Dock = DockStyle.Fill;
            InfoPanel.Location = new Point(3, 3);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(505, 347);
            InfoPanel.TabIndex = 1;
            // 
            // GithubLinkLabel
            // 
            GithubLinkLabel.AutoSize = true;
            GithubLinkLabel.Location = new Point(66, 118);
            GithubLinkLabel.Name = "GithubLinkLabel";
            GithubLinkLabel.Size = new Size(240, 15);
            GithubLinkLabel.TabIndex = 20;
            GithubLinkLabel.TabStop = true;
            GithubLinkLabel.Text = "https://github.com/ReyGrifon/ContactsApp";
            GithubLinkLabel.LinkClicked += GithubLinkLabel_LinkClicked;
            // 
            // IconsLinkLabel
            // 
            IconsLinkLabel.AutoSize = true;
            IconsLinkLabel.Location = new Point(228, 327);
            IconsLinkLabel.Margin = new Padding(0, 0, 3, 5);
            IconsLinkLabel.Name = "IconsLinkLabel";
            IconsLinkLabel.Size = new Size(68, 15);
            IconsLinkLabel.TabIndex = 19;
            IconsLinkLabel.TabStop = true;
            IconsLinkLabel.Text = "icons8.com";
            IconsLinkLabel.LinkClicked += IconsLinkLabel_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 400);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            tableLayoutPanel1.ResumeLayout(false);
            ClosePanel.ResumeLayout(false);
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label GithubLabel;
        private Label EmailTextLabel;
        private Label EmailLabel;
        private Label AuthorTextLabel;
        private Label AuthorLabel;
        private Label VersionLabel;
        private Label ContactNameLabel;
        private TextBox LicenseTextBox;
        private Label LicenseIconTextLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel ClosePanel;
        private Button CloseFormButton;
        private Panel InfoPanel;
        private LinkLabel IconsLinkLabel;
        private LinkLabel GithubLinkLabel;
    }
}