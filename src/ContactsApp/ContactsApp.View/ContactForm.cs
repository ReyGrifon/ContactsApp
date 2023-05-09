using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Поле с текстом ошибки поля fullname класса Contact
        /// </summary>
        string _fullNameError = "";

        /// <summary>
        /// Поле с текстом ошибки поля email класса Contact
        /// </summary>
        string _emailNameError = "";

        /// <summary>
        /// Поле с текстом ошибки поля phoneNumber класса Contact
        /// </summary>
        string _phoneNumberNameError = "";

        /// <summary>
        /// Поле с текстом ошибки поля dateOfBirth класса Contact
        /// </summary>
        string _dateOfBirthNameError = "";

        /// <summary>
        /// Поле с текстом ошибки поля vkId класса Contact
        /// </summary>
        string _vkIdNameError = "";

        /// <summary>
        /// объект класса Contact
        /// </summary>
        private Contact _contact;

        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact("рахмед кирганов", DateTime.Today, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            UpdateForm();
        }

        /// <summary>
        /// заполнение полей данными контакта
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            VKTextBox.Text = _contact.VkId;
        }

        /// <summary>
        /// обновление контакта записанными значениями полей
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
            _contact.DateOfBirth = DateOfBirthTimePicker.Value;
            _contact.VkId = VKTextBox.Text;
        }

        /// <summary>
        /// Поиск текста ошибки и запись под правильный формат
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        private string CheckMessageError(string error)
        {
            if (error != "")
            {
                return "•" + error + "\n";
            }
            return null;
        }

        /// <summary>
        /// Проверка на наличие ошибкок и их вывод
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            string errorMessage = "";
            errorMessage += CheckMessageError(_fullNameError) 
                + CheckMessageError(_emailNameError) 
                + CheckMessageError(_phoneNumberNameError) 
                + CheckMessageError(_dateOfBirthNameError) 
                + CheckMessageError(_vkIdNameError);
            if (errorMessage != "") 
            {
                MessageBox.Show(errorMessage, "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
            {
                UpdateContact();
                Close();
            }
        }

        /// <summary>
        /// реакция на изменение текстового поля fullName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
                _fullNameError = "";
            }
            catch (Exception error)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                _fullNameError = error.Message;
            }

        }

        /// <summary>
        /// реакция на изменение текстового поля Email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
                _emailNameError = "";
            }
            catch (Exception error)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailNameError = error.Message;
            }
        }

        /// <summary>
        /// реакция на изменение текстового поля phoneNumber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
                PhoneNumberTextBox.BackColor = Color.White;
                _phoneNumberNameError = "";
            }
            catch (Exception error)
            {
                PhoneNumberTextBox.BackColor = Color.LightPink;
                _phoneNumberNameError = error.Message;
            }
        }

        /// <summary>
        /// реакция на изменение текстового поля dateOfBirth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;
                DateOfBirthTimePicker.CalendarTitleBackColor = Color.White;
                _dateOfBirthNameError = "";
            }
            catch (Exception error)
            {
                DateOfBirthTimePicker.CalendarTitleBackColor = Color.LightPink;
                _dateOfBirthNameError = error.Message;
            }
        }

        /// <summary>
        /// реакция на изменение текстового поля vkId
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = VKTextBox.Text;
                VKTextBox.BackColor = Color.White;
                _vkIdNameError = "";
            }
            catch (Exception error)
            {
                VKTextBox.BackColor = Color.LightPink;
                _vkIdNameError = error.Message;
            }
        }

        /// <summary>
        /// обработчик нажатия на кнопку Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// обработчик наведения курсора мыши 
        /// на кнопку загрузки аватара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadPictureButton_MouseEnter(object sender, EventArgs e)
        {
            LoadPictureButton.Image = Properties.Resources.add_photo_32x32;
            LoadPictureButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// обработчик отвода курсора мыши 
        /// от кнопки загрузки аватара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadPictureButton_MouseLeave(object sender, EventArgs e)
        {
            LoadPictureButton.Image = Properties.Resources.add_photo_32x32_gray;
            LoadPictureButton.BackColor = Color.White;
        }
    }
}
