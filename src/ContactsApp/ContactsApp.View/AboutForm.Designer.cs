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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(187, 133);
            label8.Name = "label8";
            label8.Size = new Size(240, 15);
            label8.TabIndex = 15;
            label8.Text = "https://github.com/ReyGrifon/ContactsApp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 133);
            label7.Margin = new Padding(3, 10, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 14;
            label7.Text = "Github:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 108);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 13;
            label6.Text = "Sergeypchelnik@mail.ru";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 108);
            label5.Margin = new Padding(3, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 12;
            label5.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 83);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 11;
            label4.Text = "Sergey Pchelnik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 83);
            label3.Margin = new Padding(3, 10, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 10;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 58);
            label2.Margin = new Padding(3, 5, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 9;
            label2.Text = "v 1.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 23);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 8;
            label1.Text = "ContactsApp";
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Location = new Point(93, 165);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(429, 168);
            textBox1.TabIndex = 16;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AboutForm";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
    }
}