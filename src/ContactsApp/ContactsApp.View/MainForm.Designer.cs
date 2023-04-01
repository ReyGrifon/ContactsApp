namespace ContactsApp.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTableLayoutPanel = new TableLayoutPanel();
            ContactListPanel = new Panel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            EditContactButton = new PictureBox();
            AddContactButton = new PictureBox();
            RemoveContactButton = new PictureBox();
            FindLabel = new Label();
            FindTextBox = new TextBox();
            ContactsListBox = new ListBox();
            ContactInfoPanel = new Panel();
            BirthdayPanel = new Panel();
            BirthdayPanelCloseButton = new Button();
            BirthdaySurnamesLabel = new Label();
            BirthdayListLabel = new Label();
            NotifyPictureBox = new PictureBox();
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthTextBox = new TextBox();
            DateOfBirthLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            MainTableLayoutPanel.SuspendLayout();
            ContactListPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).BeginInit();
            ContactInfoPanel.SuspendLayout();
            BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotifyPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 238F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Controls.Add(ContactListPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(ContactInfoPanel, 1, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Margin = new Padding(6);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(800, 450);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // ContactListPanel
            // 
            ContactListPanel.Controls.Add(ButtonsTableLayoutPanel);
            ContactListPanel.Controls.Add(FindLabel);
            ContactListPanel.Controls.Add(FindTextBox);
            ContactListPanel.Controls.Add(ContactsListBox);
            ContactListPanel.Dock = DockStyle.Fill;
            ContactListPanel.Location = new Point(3, 3);
            ContactListPanel.Name = "ContactListPanel";
            ContactListPanel.Size = new Size(232, 444);
            ContactListPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsTableLayoutPanel.ColumnCount = 3;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.Controls.Add(EditContactButton, 1, 0);
            ButtonsTableLayoutPanel.Controls.Add(AddContactButton, 0, 0);
            ButtonsTableLayoutPanel.Controls.Add(RemoveContactButton, 2, 0);
            ButtonsTableLayoutPanel.Location = new Point(3, 406);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(226, 35);
            ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // EditContactButton
            // 
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.Location = new Point(75, 0);
            EditContactButton.Margin = new Padding(0);
            EditContactButton.Name = "EditContactButton";
            EditContactButton.Size = new Size(75, 35);
            EditContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            EditContactButton.TabIndex = 3;
            EditContactButton.TabStop = false;
            EditContactButton.MouseEnter += EditContactButton_MouseEnter;
            EditContactButton.MouseLeave += EditContactButton_MouseLeave;
            // 
            // AddContactButton
            // 
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.Location = new Point(0, 0);
            AddContactButton.Margin = new Padding(0);
            AddContactButton.Name = "AddContactButton";
            AddContactButton.Size = new Size(75, 35);
            AddContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            AddContactButton.TabIndex = 4;
            AddContactButton.TabStop = false;
            AddContactButton.MouseClick += AddContactButton_MouseClick;
            AddContactButton.MouseEnter += AddContactButton_MouseEnter;
            AddContactButton.MouseLeave += AddContactButton_MouseLeave;
            // 
            // RemoveContactButton
            // 
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.Location = new Point(150, 0);
            RemoveContactButton.Margin = new Padding(0);
            RemoveContactButton.Name = "RemoveContactButton";
            RemoveContactButton.Size = new Size(76, 35);
            RemoveContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            RemoveContactButton.TabIndex = 5;
            RemoveContactButton.TabStop = false;
            RemoveContactButton.MouseEnter += RemoveContactButton_MouseEnter;
            RemoveContactButton.MouseLeave += RemoveContactButton_MouseLeave;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(3, 6);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(33, 15);
            FindLabel.TabIndex = 2;
            FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(42, 3);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(187, 23);
            FindTextBox.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            ContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.IntegralHeight = false;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Items.AddRange(new object[] { "Никита Буянов", "Тодд Говард", "Фил Спенсер", "Хидэо Кодзима", "Гейб Ньюэлл", "Хидэтака Миядзаки", "Кан Гао", "Уильям Пеллен", "Кристофер Ларкин", "Бобби Котик" });
            ContactsListBox.Location = new Point(3, 32);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(226, 374);
            ContactsListBox.TabIndex = 0;
            // 
            // ContactInfoPanel
            // 
            ContactInfoPanel.Controls.Add(BirthdayPanel);
            ContactInfoPanel.Controls.Add(VKTextBox);
            ContactInfoPanel.Controls.Add(VKLabel);
            ContactInfoPanel.Controls.Add(DateOfBirthTextBox);
            ContactInfoPanel.Controls.Add(DateOfBirthLabel);
            ContactInfoPanel.Controls.Add(PhoneNumberTextBox);
            ContactInfoPanel.Controls.Add(PhoneNumberLabel);
            ContactInfoPanel.Controls.Add(EmailTextBox);
            ContactInfoPanel.Controls.Add(EmailLabel);
            ContactInfoPanel.Controls.Add(FullNameTextBox);
            ContactInfoPanel.Controls.Add(FullNameLabel);
            ContactInfoPanel.Controls.Add(PhotoPictureBox);
            ContactInfoPanel.Dock = DockStyle.Fill;
            ContactInfoPanel.Location = new Point(241, 3);
            ContactInfoPanel.Name = "ContactInfoPanel";
            ContactInfoPanel.Size = new Size(556, 444);
            ContactInfoPanel.TabIndex = 1;
            // 
            // BirthdayPanel
            // 
            BirthdayPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BirthdayPanel.BackColor = Color.FromArgb(245, 245, 255);
            BirthdayPanel.Controls.Add(BirthdayPanelCloseButton);
            BirthdayPanel.Controls.Add(BirthdaySurnamesLabel);
            BirthdayPanel.Controls.Add(BirthdayListLabel);
            BirthdayPanel.Controls.Add(NotifyPictureBox);
            BirthdayPanel.Location = new Point(3, 361);
            BirthdayPanel.Name = "BirthdayPanel";
            BirthdayPanel.Size = new Size(550, 80);
            BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            BirthdayPanelCloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BirthdayPanelCloseButton.FlatAppearance.BorderSize = 0;
            BirthdayPanelCloseButton.FlatStyle = FlatStyle.Flat;
            BirthdayPanelCloseButton.ForeColor = SystemColors.ControlDarkDark;
            BirthdayPanelCloseButton.Image = Properties.Resources.close_32x32;
            BirthdayPanelCloseButton.Location = new Point(515, 3);
            BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            BirthdayPanelCloseButton.Size = new Size(32, 32);
            BirthdayPanelCloseButton.TabIndex = 15;
            BirthdayPanelCloseButton.UseVisualStyleBackColor = true;
            // 
            // BirthdaySurnamesLabel
            // 
            BirthdaySurnamesLabel.AutoSize = true;
            BirthdaySurnamesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BirthdaySurnamesLabel.ForeColor = Color.FromArgb(0, 144, 255);
            BirthdaySurnamesLabel.Location = new Point(81, 43);
            BirthdaySurnamesLabel.Name = "BirthdaySurnamesLabel";
            BirthdaySurnamesLabel.Size = new Size(221, 15);
            BirthdaySurnamesLabel.TabIndex = 14;
            BirthdaySurnamesLabel.Text = "Абакумов, Бондарева, Смирнов и др.";
            // 
            // BirthdayListLabel
            // 
            BirthdayListLabel.AutoSize = true;
            BirthdayListLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BirthdayListLabel.ForeColor = Color.FromArgb(0, 144, 255);
            BirthdayListLabel.Location = new Point(81, 24);
            BirthdayListLabel.Name = "BirthdayListLabel";
            BirthdayListLabel.Size = new Size(118, 15);
            BirthdayListLabel.TabIndex = 13;
            BirthdayListLabel.Text = "Today is Birthday of:";
            // 
            // NotifyPictureBox
            // 
            NotifyPictureBox.Image = Properties.Resources.info_48x48;
            NotifyPictureBox.Location = new Point(3, 3);
            NotifyPictureBox.Name = "NotifyPictureBox";
            NotifyPictureBox.Size = new Size(74, 74);
            NotifyPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            NotifyPictureBox.TabIndex = 12;
            NotifyPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            VKTextBox.Location = new Point(109, 240);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(181, 23);
            VKTextBox.TabIndex = 10;
            VKTextBox.KeyPress += VKTextBox_KeyPress;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(109, 222);
            VKLabel.Margin = new Padding(3, 10, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(24, 15);
            VKLabel.TabIndex = 9;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            DateOfBirthTextBox.Location = new Point(109, 186);
            DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            DateOfBirthTextBox.Size = new Size(181, 23);
            DateOfBirthTextBox.TabIndex = 8;
            DateOfBirthTextBox.KeyPress += DateOfBirthTextBox_KeyPress;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(109, 168);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(76, 15);
            DateOfBirthLabel.TabIndex = 7;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(109, 132);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(181, 23);
            PhoneNumberTextBox.TabIndex = 6;
            PhoneNumberTextBox.Text = "+7 (996) 731-08-94";
            PhoneNumberTextBox.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(109, 114);
            PhoneNumberLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(109, 78);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(444, 23);
            EmailTextBox.TabIndex = 4;
            EmailTextBox.Text = "Buyanov@mail.ru";
            EmailTextBox.KeyPress += EmailTextBox_KeyPress;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(109, 60);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.BackColor = Color.FromArgb(245, 245, 255);
            FullNameTextBox.Location = new Point(109, 24);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(444, 23);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.Text = "Буянов Никита";
            FullNameTextBox.KeyPress += FullNameTextBox_KeyPress;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(109, 6);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            PhotoPictureBox.Location = new Point(3, 3);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(100, 100);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhotoPictureBox.TabIndex = 0;
            PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "MainForm";
            Text = "ContactApp";
            KeyDown += MainForm_KeyDown;
            MainTableLayoutPanel.ResumeLayout(false);
            ContactListPanel.ResumeLayout(false);
            ContactListPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).EndInit();
            ContactInfoPanel.ResumeLayout(false);
            ContactInfoPanel.PerformLayout();
            BirthdayPanel.ResumeLayout(false);
            BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotifyPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Panel ContactListPanel;
        private Label FindLabel;
        private TextBox FindTextBox;
        private ListBox ContactsListBox;
        private Panel ContactInfoPanel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private TextBox VKTextBox;
        private Label VKLabel;
        private TextBox DateOfBirthTextBox;
        private Label DateOfBirthLabel;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private PictureBox PhotoPictureBox;
        private Panel BirthdayPanel;
        private Button BirthdayPanelCloseButton;
        private Label BirthdaySurnamesLabel;
        private Label BirthdayListLabel;
        private PictureBox NotifyPictureBox;
        private PictureBox EditContactButton;
        private PictureBox AddContactButton;
        private PictureBox RemoveContactButton;
    }
}