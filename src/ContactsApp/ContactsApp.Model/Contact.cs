using System.Text.RegularExpressions;

namespace ContactsApp.Model
{
    /// <summary>
    /// Информационны класс Контакт
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Полное имя
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Дата рождения 
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// номер телефона 
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Id  в VK
        /// </summary>
        private string _vkId;

        /// <summary>
        /// электронная почта 
        /// </summary>
        private string _email;

        /// <summary>
        /// Шаблон номера телефона +7(999)845-11-22 или 8(888)555-33-22
        /// </summary>
        private string _phoneNumberRegex = @"(^[+]?[0-9]{1}\([0-9]{3}\)[0-9]{3}-[0-9]{2}-[0-9]{2})";

        /// <summary>
        /// Возвращает или задаёт имя 
        /// </summary>
        public string FullName
        { 
            get 
            { 
                return _fullName; 
            } 
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("FullName can't be equal than 0 symbols");
                }
                if (value.Length > 100)
                {
                    throw new ArgumentException("Name can't be longer than 100 symbols");
                }
                string normalFullName = "";
                string[] words = value.Split(" ");
                foreach (string word in words)
                {
                    normalFullName += word[0].ToString().ToUpper() + word.Substring(1) + " ";
                }
                _fullName = normalFullName;
            } 
        }

        /// <summary>
        /// Возвращает или задаёт дату рождения 
        /// </summary>
        public DateTime DateOfBirth
        {
            get 
            {
                return _dateOfBirth; 
            }
            set 
            {
                if (value.Year < 1900 || value > DateTime.Today)
                {
                    throw new ArgumentException("Year of birth can't be curent year and before 1900");
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт номер телефона
        /// </summary>
        public string PhoneNumber
        {
            get 
            {
                return _phoneNumber;
            }
            set 
            {
                if (!Regex.IsMatch(value,_phoneNumberRegex)!)
                {
                    throw new ArgumentException("Number does not fit the pattern 8(123)000-45-67 or +7(123)000-45-67");
                }
                _phoneNumber = value; 
            }
        }

        /// <summary>
        /// Возвращает или задаёт VK ID
        /// </summary>
        public string VkId
        {
            get 
            { 
            return _vkId;
            }
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("VK ID can't be eqal than 0 symbols");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("VK ID can't be longer than 50 symbols");
                }
                _vkId = value; 
            }
        }

        /// <summary>
        /// Возвращает или задаёт адрес почты
        /// </summary>
        public string Email
        {
            get 
            {
                return _email;
            }
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Email can't be equal than 0 symbols");
                }
                if (value.Length > 100)
                {
                    throw new ArgumentException("Email can't be longer than 100 symbols");
                }
                _email = value; 
            }
        }

        /// <summary>
        /// Конструктор создания экземпляра класса Contaact
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="vkId"></param>
        /// <param name="email"></param>
        public Contact(string fullName,DateTime dateOfBirth, string phoneNumber, string vkId, string email)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            VkId = vkId;
            Email = email;
        }

        /// <summary>
        /// Клонирование контакта
        /// </summary>
        /// <returns></returns>
        public object Clone() => new Contact(FullName, DateOfBirth, PhoneNumber, VkId, Email);
    }
}
