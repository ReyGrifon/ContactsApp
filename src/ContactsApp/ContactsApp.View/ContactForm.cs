using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadPictureButton_MouseEnter(object sender, EventArgs e)
        {
            LoadPictureButton.Image = Properties.Resources.add_photo_32x32;
            LoadPictureButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void LoadPictureButton_MouseLeave(object sender, EventArgs e)
        {
            LoadPictureButton.Image = Properties.Resources.add_photo_32x32_gray;
            LoadPictureButton.BackColor = Color.White;
        }
    }
}
