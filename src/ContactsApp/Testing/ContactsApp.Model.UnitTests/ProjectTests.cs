using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    internal class ProjectTests
    {
        [Test(Description = "позитивный тест геттера Contacts")]
        public void Project_SetCorrectValue_ReturnSameValue()
        {
            //Arrange
            var project = new Project();
            var contacts = new List<Contact>();
            var firstContact = new Contact("Алексей Киров", DateTime.Today, "8(123)000-45-67",
                "1234pqw34", "BadPerson@gmail.com");
            var secondContact = new Contact("Рахмед Кирганов", DateTime.Today, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            contacts.Add(firstContact);
            contacts.Add(secondContact);
            var exceptedContacts = contacts;
            //Act
            project.Contacts.Add(firstContact);
            project.Contacts.Add(secondContact);
            var actualContacts = project.Contacts;
            
            //Assert
            Assert.AreEqual(exceptedContacts, actualContacts);

        }

        [Test(Description = "Позитивный тест метода SortContacts")]
        public void Contacts_SortContacts_ReturnSortedContacts()
        {
            //Arrange
            var firstContact = new Contact("Алексей Киров", DateTime.Today, "8(123)000-45-67",
                "1234pqw34", "BadPerson@gmail.com");
            var secondContact = new Contact("Василий Квашин", DateTime.Today, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            var thirdContact = new Contact("Рахмед Кирганов", DateTime.Today, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            List<Contact> sortedContacts = new List<Contact>();
            sortedContacts.Add(firstContact);
            sortedContacts.Add(secondContact);
            sortedContacts.Add(thirdContact);
            //Act
            var exceptedSortContacts = sortedContacts;
            Project project = new Project();
            project.Contacts.Add(thirdContact);
            project.Contacts.Add(secondContact);
            project.Contacts.Add(firstContact);
            var actualSortContacts = project.SortContacts(project.Contacts);
            //Assert
            Assert.AreEqual(exceptedSortContacts, actualSortContacts);
        }

        [Test(Description = "позитивный тест метода FindContacts")]
        public void Contacts_FindContact_ReturnFindedContact()
        {
            //Arrange
            var project = new Project();
            var contact = new Contact("Василий Квашин", DateTime.Today, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            List<Contact> contacts = new List<Contact>();
            contacts.Add(contact);
            var exceptedFindedContact = contacts;
            var substring = "Василий";
            project.Contacts.Add(contact);
            //Act
            var findedContact = project.FindContacts(substring);
            //Assert
            Assert.AreEqual(exceptedFindedContact,findedContact);
        }

        [Test(Description = "позитивный тест методы FindByBirthday")]
        public void Contacts_FindBirthDayContacts_ReturnFindedContacts()
        {
            //Arrange
            var project = new Project();
            DateTime dateOfBirth = new DateTime(2012,12,01);
            var findDate = dateOfBirth;
            var contact = new Contact("Василий Квашин", 
                dateOfBirth, "8(123)000-45-67",
                "dsfsdfsds", "GoodPerson@gmail.com");
            List<Contact> contacts = new List<Contact>();
            contacts.Add(contact);
            var exceptedFindedContact = contacts;
            project.Contacts.Add(contact);
            //Act
            var findedContact = project.FindByBirthday(findDate);
            //Assert
            Assert.AreEqual(exceptedFindedContact,findedContact);
        }
    }
}
