using ContactsApp.Model;
using System;
using System.Reflection;
using System.Linq;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Project С контактами
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Лист с контактами для отображения в приложении
        /// </summary>
        private List<Contact> _curentContacts = new List<Contact>();

        /// <summary>
        /// объект для сохранения и загрузки Project
        /// </summary>
        private ProjectManager _projectManager = new ProjectManager();

        public MainForm()
        {
            InitializeComponent();
            _project = _projectManager.LoadProject();
            UpdateBirthdayContacts();
            UpdateListBox();
        }

        /// <summary>
        /// Обновление ListBox
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            var findedContacts = _project.SearchContacts(FindTextBox.Text);
            _curentContacts = _project.SortContacts(findedContacts);
            foreach (var contacts in _curentContacts)
            {
                ContactsListBox.Items.Add(contacts.FullName);
            }
        }

        /// <summary>
        /// Обновление панели BirthdayPanel fullName именинников
        /// </summary>
        private void UpdateBirthdayContacts()
        {
            List<Contact> _birthdayContacts = new List<Contact>();
            _birthdayContacts = _project.FindByBirthday(DateTime.Today);
            BirthdaySurnamesLabel.Text = "";
            foreach (Contact contact in _birthdayContacts)
            {
                if (contact == _birthdayContacts.Last())
                {
                    BirthdaySurnamesLabel.Text += contact.FullName;
                    return;
                }
                BirthdaySurnamesLabel.Text += contact.FullName + ", ";
            }
        }

        /// <summary>
        /// Обновление информационных полей соответсвенно выбранному контакту
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact contact = _curentContacts[index];
            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            string dateOfBirth = contact.DateOfBirth.ToString("yyyy.MM.dd");
            DateOfBirthTextBox.Text = dateOfBirth;
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

        //TODO: убрать в отдельный класс
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
            string fullName = names[random.Next(names.Length)] + " " +
                surnames[random.Next(surnames.Length)];
            Contact contact = new Contact(fullName, DateTime.Today, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            _project.Contacts.Add(contact);
        }

        /// <summary>
        /// Удаление контакта
        /// </summary>
        private void RemoveContact()
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }
            string message = "Do you really want to remove " +
                _curentContacts[selectedIndex].FullName + "?";
            DialogResult result;
            result = MessageBox.Show(message, "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {

                _project.Contacts.Remove(_curentContacts[selectedIndex]);
                selectedIndex = -1;
                _curentContacts = _project.Contacts;
            }

        }

        /// <summary>
        /// Редактирование контакта
        /// </summary>
        private void EditContact()
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }
            var selectedContact = _curentContacts[selectedIndex];
            var form = new ContactForm();
            form.Contact = (Contact)selectedContact.Clone();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var updatedContact = form.Contact;
                _project.Contacts.Remove(selectedContact);
                _project.Contacts.Add(updatedContact);
            }
        }

        /// <summary>
        /// Закрытие панели с именниками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        /// <summary>
        /// Редактирование контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var index = ContactsListBox.SelectedIndex;
            EditContact();
            UpdateListBox();
            UpdateSelectedContact(index);
            _projectManager.SaveProject(_project);
        }

        /// <summary>
        /// Удаление выбранного контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact();
            UpdateListBox();
            ClearSelectedObject();
            _projectManager.SaveProject(_project);
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
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            _projectManager.SaveProject(_project);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            _curentContacts = _project.SearchContacts(FindTextBox.Text);
            UpdateListBox();
        }

        private void AddContactButton_MouseClick(object sender, MouseEventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var contact = form.Contact;
                _project.Contacts.Add(contact);
            }
            _curentContacts = _project.Contacts;
            //Убрать добавление рандомного контакта в отдельный класс
            //AddContact();
            UpdateListBox();
            _projectManager.SaveProject(_project);
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
    }
}