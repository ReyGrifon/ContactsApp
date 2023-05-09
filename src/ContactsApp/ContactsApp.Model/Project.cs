using System;

namespace ContactsApp.Model
{
    /// <summary>
    /// Класс с списком контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех созданных контактов
        /// </summary>
        public List<Contact> Contacts { get; set; } = new();

        /// <summary>
        /// Поиск контакта по подстроке одного из полей
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<Contact> SearchContacts(string query)
        {
            var options = StringComparison.OrdinalIgnoreCase;
            return Contacts.Where(c =>
                c.FullName.Contains(query) ||
                c.Email.Contains(query) ||
                c.PhoneNumber.Contains(query) ||
                c.VkId.IndexOf(query, options) >= 0).ToList();
        }

        /// <summary>
        /// Сортировка контактов
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns></returns>
        private List<Contact> SortContacts(List<Contact> contacts) 
        {
            contacts.Sort((c1, c2) => c1.FullName.CompareTo(c2.FullName));
            return contacts;
        }

        /// <summary>
        /// Поиск Контактов с совпадающим днём рождения
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private List<Contact> FindByBirthday(DateTime time)
        {
            List<Contact> BirhdayContacts = new List<Contact>();
            foreach (Contact contact in Contacts)
            {
                if (contact.DateOfBirth.ToString("dd.MM") == time.ToString("dd.MM"))
                {
                    BirhdayContacts.Add(contact);
                }
            }
            return BirhdayContacts;
        }
    }
}
