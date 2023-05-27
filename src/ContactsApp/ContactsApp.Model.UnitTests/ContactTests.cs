using NUnit.Framework;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов" +
                  "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов",
            "Должно возникать исключение, если имя - 100 символов или больше",
            TestName = "присвоение строки длинной в 100 символов в качестве имени")]
        [TestCase("", "Должно возникать исключение, если имя - пустая строка",
            TestName = "присвоение пустой строки в качестве имени")]
        public void FullName_SetWrongName_ThrowException(string wrongFullName, string message)
        {
            // Arrange
            var contact = new Contact();
            // Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.FullName = wrongFullName;

                },
                message);
        }

        [Test(Description = "присвоение корректного значения")]
        public void FullName_SetCorrectValue_ReturnsSameValue()
            {
                // Arrange
                var contact = new Contact();
                var correctFullName = "Pchelnik Sergey Sergeevich";
                var expected = correctFullName;

                // Act
                contact.FullName = correctFullName;
                var actual = contact.FullName;

                // Assert
                Assert.AreEqual(expected, actual);
            }
            
        [TestCase("2024-1-20","Должно возникать условие если дата - пустая строка",
                TestName = "Присвоение пустой строки в поле даты")]
        [TestCase("1800-1-20", "Должно возникать условие если дата ранее 1900",
                TestName = "Присвоение пустой строки в поле даты")]
        public void DateOfBirth_SetWrongDate_ThrowException(string wrongDate, string message)
            {
                var contact = new Contact();
                Assert.Throws<ArgumentException>(
                    () => { contact.DateOfBirth = Convert.ToDateTime(wrongDate); },
                    message);
            }
            
        [Test(Description = "получение корректного значения даты рождения")]
        public void DateOfBirth_SetCorrectValue_ReturnsSameValue()
            {
                //Arrange
                var contact = new Contact();
                var correctDate = DateTime.Today;
                var expected = correctDate;

                //Act
                contact.DateOfBirth = correctDate;
                var actual = contact.DateOfBirth;

                //Assert
                Assert.AreEqual(expected, actual);
            }

        [Test(Description = "получение корректного значения номера телефона")]
        public void PhoneNumber_SetCorrectValue_ReturnsSameValue()
            {
                //Arrange
                var contact = new Contact();
                var correctNumber = "+7(996)201-73-22";
                var excepted = correctNumber;

                //Act
                contact.PhoneNumber = correctNumber;
                var actual = contact.PhoneNumber;

                //Assert
                Assert.AreEqual(excepted,actual);
            }

        [TestCase("","Должно возникать условие если значение - пустая строка", 
                TestName = "Присвоение пустой строки в поле номера телефона")]
        [TestCase("asdasdads","должно возникать условие если значение несответствует шаблону",
            TestName = "Присвоение недоступной строки в поле номера телефона")]
        public void PhoneNumber_SetWrongNumber_ThrowException(string wrongNumber, string message)
            {
                var contact = new Contact();
                Assert.Throws<ArgumentException>(
                    () =>
                    {
                        contact.PhoneNumber = wrongNumber;
                    }, message);
            }

        [Test(Description = "Получение корректного значения VkID")]
        public void VkId_SetCorrectValue_ReturnSameValue()
        {
            //Arrange
            var contact = new Contact();
            var correctId = "clotterman";
            var excepted = correctId;
            
            //Act
            contact.VkId = correctId;
            var actual = contact.VkId;

            //Assert
            Assert.AreEqual(excepted,actual);
        }
        [TestCase("", "должно возникать условие, если значение - пустая строка",
            TestName = "Присвоение пустой строки в поле VkId")]
        [TestCase("Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wro",
            "должно возникать условие, если значение превышает 50 символов",
            TestName = "Присвоение некорректной строки в поле VkId")]
        public void VkId_SetWrongValue_ThrowException(string wrongId, string message)
        {
            // Arrange
            var contact = new Contact();
            // Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.VkId = wrongId;

                },
                message);
        }
        
        [Test(Description = "Получение корректного значения Email")]
        public void Email_SetCorrectValue_ReturnSameValue()
        {
            //Arrange
            var contact = new Contact();
            var correctEmail = "clotterman";
            var excepted = correctEmail;
            
            //Act
            contact.Email = correctEmail;
            var actual = contact.Email;

            //Assert
            Assert.AreEqual(excepted,actual);
        }
        
        [TestCase("", "должно возникать условие, если значение - пустая строка",
            TestName = "Присвоение пустой строки в поле Email")]
        [TestCase("Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wro" +
                  "Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wrong-Wro",
            "должно возникать условие, если значение превышает 100 символов",
            TestName = "Присвоение некорректной строки в поле Email")]
        public void Email_SetWrongValue_ThrowException(string wrongEmail, string message)
        {
            // Arrange
            var contact = new Contact();
            // Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    contact.Email = wrongEmail;

                },
                message);
        }
    }
}