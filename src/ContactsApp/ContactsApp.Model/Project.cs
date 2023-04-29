using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class Project
    {

        List<Contact> contacts = new();


        public List<Contact> Contacts
        {
            get { return contacts; }
            set { contacts = value; }
        }

        public Project(string fullName, DateTime dateOfBirth, string phonenumber, string vkId, string email)
        {
            contacts = new List<Contact>();
        }

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
        private List<Contact> FindByDayOfBirth(DateTime time)
        {
            List<Contact> BirhdayContacts = new List<Contact>();
            foreach (Contact contact in contacts)
            {
                if (contact.DateOfBirth == time)
                {
                    BirhdayContacts.Add(contact);
                }
            }
            return BirhdayContacts;
        }
    }
}
