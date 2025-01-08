using Business.Factories;
using Business.Dtos;
using Business.Models;
using Xunit;

namespace Business.Test.Factories
{
    public class ContactFactory_Tests
    {
        [Fact]
        public void Create_ShouldReturnContactRegistrationForm()
        {
            // Act
            var result = ContactFactory.Create();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ContactRegistrationForm>(result);
        }

        [Fact]
        public void Create_ShouldReturnContact()
        {
            // Arrange
            var contactForm = new ContactRegistrationForm
            {
                FirstName = "Test",
                LastName = "Testsson",
                Email = "Test@domain.com",
                PhoneNumber = "123456789",
                Address = "123 Test Street",
                PostalCode = "12345",
                City = "Test City"
            };

            // Act
            var result = ContactFactory.Create(contactForm);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<Contact>(result);
            Assert.Equal(contactForm.FirstName, result.FirstName);
            Assert.Equal(contactForm.LastName, result.LastName);
            Assert.Equal(contactForm.Email, result.Email);
            Assert.Equal(contactForm.PhoneNumber, result.PhoneNumber);
            Assert.Equal(contactForm.Address, result.Address);
            Assert.Equal(contactForm.PostalCode, result.PostalCode);
            Assert.Equal(contactForm.City, result.City);
        }
    }
}
