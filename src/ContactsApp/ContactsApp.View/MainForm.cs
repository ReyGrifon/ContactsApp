using ContactsApp.Model;
using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Project С контактами
        /// </summary>
        private Project _project = new Project();

        public MainForm()
        {
            InitializeComponent();
            AddContact();
            UpdateListBox();
        }

        /// <summary>
        /// Обновление ListBox
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            foreach (var contacts in _project.Contacts)
            {
                ContactsListBox.Items.Add(contacts.FullName);
            }
        }

        /// <summary>
        /// Обновление информационных полей соответсвенно выбранному контакту
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact contact = _project.Contacts[index];
            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            string DayOfBirth = contact.DateOfBirth.Day.ToString() + "." + 
                contact.DateOfBirth.Month.ToString() + "." + 
                contact.DateOfBirth.Year.ToString();
            DateOfBirthTextBox.Text = DayOfBirth;
            VKTextBox.Text = contact.VkId;
        }

        /// <summary>
        /// Очищение информационных полей при отсутсвии выбранного контакта
        /// </summary>
        private void ClearSelectedObject()
        {
            FullNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            DateOfBirthTextBox.Text = "";
            VKTextBox.Text = "";
        }

        /// <summary>
        /// Добавление случайного контакта
        /// </summary>
        private void AddContact()
        {
            var random = new Random();
            string[] names = { "сергей", "николай", "хидетака", "гейб","фил",
                "хидео","тодд","кан","алексей" };

            string[] surnames = { "буянов", "ньюэлл", "кодзима", "спенсер",
                "иванов", "кирпечёв", "котик","ларкин", "Петров" };

            Project project = new Project();

            Contact contact = new Contact(names[random.Next(names.Length)] + " " +
                surnames[random.Next(surnames.Length)], DateTime.Today, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            _project.Contacts.Add(contact);
        }

        /// <summary>
        /// Удаление выбранного контакта
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                return;
            }
            string message = "Do you really want to remove " +
                _project.Contacts[index].FullName + "?";
            DialogResult result;
            result = MessageBox.Show(message, "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                _project.Contacts.Remove(_project.Contacts[index]);
            }

        }

        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        private void AddContactButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Откоментировать при добавлении связи между окнами
            //var form = new ContactForm();
            //form.ShowDialog();
            AddContact();
            UpdateListBox();
        }

        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Закрытие панели с именниками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Hide();
        }
        /// <summary>
        /// Редактирование контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Удаление выбранного контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Изменение информации в полях справа при изменении поля ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                ClearSelectedObject();
                return;
            }
            UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Предупреждение для закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Do you really want to exit ?";
            DialogResult result;
            result = MessageBox.Show(message, "", MessageBoxButtons.YesNo);
            if(result != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }
    }
}