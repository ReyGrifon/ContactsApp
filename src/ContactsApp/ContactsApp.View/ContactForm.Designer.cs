namespace ContactsApp.View
{
    partial class ContactForm
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
            MaintableLayoutPanel = new TableLayoutPanel();
            InfoContactPanel = new Panel();
            LoadPictureButton = new PictureBox();
            DateOfBirthTimePicker = new DateTimePicker();
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            CancelPanel = new Panel();
            CancelButton = new Button();
            OKButton = new Button();
            MaintableLayoutPanel.SuspendLayout();
            InfoContactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoadPictureButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            CancelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MaintableLayoutPanel
            // 
            MaintableLayoutPanel.ColumnCount = 1;
            MaintableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MaintableLayoutPanel.Controls.Add(InfoContactPanel, 0, 0);
            MaintableLayoutPanel.Controls.Add(CancelPanel, 0, 1);
            MaintableLayoutPanel.Dock = DockStyle.Fill;
            MaintableLayoutPanel.Location = new Point(0, 0);
            MaintableLayoutPanel.Name = "MaintableLayoutPanel";
            MaintableLayoutPanel.RowCount = 2;
            MaintableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MaintableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            MaintableLayoutPanel.Size = new Size(511, 343);
            MaintableLayoutPanel.TabIndex = 0;
            // 
            // InfoContactPanel
            // 
            InfoContactPanel.Controls.Add(LoadPictureButton);
            InfoContactPanel.Controls.Add(DateOfBirthTimePicker);
            InfoContactPanel.Controls.Add(VKTextBox);
            InfoContactPanel.Controls.Add(VKLabel);
            InfoContactPanel.Controls.Add(DateOfBirthLabel);
            InfoContactPanel.Controls.Add(PhoneNumberTextBox);
            InfoContactPanel.Controls.Add(PhoneNumberLabel);
            InfoContactPanel.Controls.Add(EmailTextBox);
            InfoContactPanel.Controls.Add(EmailLabel);
            InfoContactPanel.Controls.Add(FullNameTextBox);
            InfoContactPanel.Controls.Add(FullNameLabel);
            InfoContactPanel.Controls.Add(PhotoPictureBox);
            InfoContactPanel.Dock = DockStyle.Fill;
            InfoContactPanel.Location = new Point(3, 3);
            InfoContactPanel.Name = "InfoContactPanel";
            InfoContactPanel.Size = new Size(505, 290);
            InfoContactPanel.TabIndex = 0;
            // 
            // LoadPictureButton
            // 
            LoadPictureButton.Image = Properties.Resources.add_photo_32x32_gray;
            LoadPictureButton.Location = new Point(45, 115);
            LoadPictureButton.Name = "LoadPictureButton";
            LoadPictureButton.Size = new Size(32, 32);
            LoadPictureButton.SizeMode = PictureBoxSizeMode.CenterImage;
            LoadPictureButton.TabIndex = 14;
            LoadPictureButton.TabStop = false;
            LoadPictureButton.MouseEnter += LoadPictureButton_MouseEnter;
            LoadPictureButton.MouseLeave += LoadPictureButton_MouseLeave;
            // 
            // DateOfBirthTimePicker
            // 
            DateOfBirthTimePicker.CalendarMonthBackground = Color.White;
            DateOfBirthTimePicker.Location = new Point(117, 189);
            DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            DateOfBirthTimePicker.Size = new Size(180, 23);
            DateOfBirthTimePicker.TabIndex = 13;
            DateOfBirthTimePicker.Value = new DateTime(2000, 4, 1, 11, 56, 0, 0);
            DateOfBirthTimePicker.ValueChanged += DateOfBirthTimePicker_ValueChanged;
            // 
            // VKTextBox
            // 
            VKTextBox.BackColor = Color.White;
            VKTextBox.Location = new Point(117, 241);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(180, 23);
            VKTextBox.TabIndex = 12;
            VKTextBox.TextChanged += VKTextBox_TextChanged;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(117, 223);
            VKLabel.Margin = new Padding(3, 10, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(24, 15);
            VKLabel.TabIndex = 11;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(117, 171);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(76, 15);
            DateOfBirthLabel.TabIndex = 9;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.BackColor = Color.White;
            PhoneNumberTextBox.Location = new Point(117, 135);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(180, 23);
            PhoneNumberTextBox.TabIndex = 8;
            PhoneNumberTextBox.Text = "+7 (996) 731-08-94";
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(117, 117);
            PhoneNumberLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 7;
            PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = Color.White;
            EmailTextBox.Location = new Point(117, 81);
            EmailTextBox.Margin = new Padding(3, 3, 11, 3);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(379, 23);
            EmailTextBox.TabIndex = 6;
            EmailTextBox.Text = "Buyanov@mail.ru";
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(117, 63);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.BackColor = Color.White;
            FullNameTextBox.Location = new Point(117, 27);
            FullNameTextBox.Margin = new Padding(3, 3, 11, 3);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(379, 23);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.Text = "Буянов Никита";
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(117, 9);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            PhotoPictureBox.Location = new Point(11, 9);
            PhotoPictureBox.Margin = new Padding(11, 3, 3, 3);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(100, 100);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhotoPictureBox.TabIndex = 0;
            PhotoPictureBox.TabStop = false;
            // 
            // CancelPanel
            // 
            CancelPanel.BackColor = Color.WhiteSmoke;
            CancelPanel.Controls.Add(CancelButton);
            CancelPanel.Controls.Add(OKButton);
            CancelPanel.Dock = DockStyle.Fill;
            CancelPanel.Location = new Point(0, 296);
            CancelPanel.Margin = new Padding(0);
            CancelPanel.Name = "CancelPanel";
            CancelPanel.Size = new Size(511, 47);
            CancelPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(421, 12);
            CancelButton.Margin = new Padding(5, 3, 15, 12);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(336, 12);
            OKButton.Margin = new Padding(3, 3, 5, 3);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 343);
            Controls.Add(MaintableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ContactForm";
            ShowIcon = false;
            MaintableLayoutPanel.ResumeLayout(false);
            InfoContactPanel.ResumeLayout(false);
            InfoContactPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoadPictureButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            CancelPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MaintableLayoutPanel;
        private Panel InfoContactPanel;
        private PictureBox PhotoPictureBox;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
        private Label DateOfBirthLabel;
        private TextBox VKTextBox;
        private Label VKLabel;
        private Panel CancelPanel;
        private Button CancelButton;
        private Button OKButton;
        private PictureBox LoadPictureButton;
        private DateTimePicker DateOfBirthTimePicker;
    }
}