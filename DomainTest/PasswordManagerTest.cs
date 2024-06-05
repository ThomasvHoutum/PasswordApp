using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Managers;
using Moq;
using Xunit;

namespace DomainTest
{
    public class PasswordManagerTest
    {
        #region LoginDetail
        
        [Fact]
        public void AddLoginDetail_ShouldAddEntry()
        {
            // Arrange
            var mockFileHelper = new Mock<IFileHelper>();
            var mockEncryptionHelper = new Mock<IEncryptionHelper>();
            var passwordManager = new PasswordManager(mockFileHelper.Object, mockEncryptionHelper.Object);
            var loginDetail = new LoginDetail("Google", "John Doe", "john@example.com", "password123", new List<SecurityQuestion>());

            // Act
            passwordManager.LoginDetailRepository.Add(loginDetail);

            // Assert
            var entries = passwordManager.LoginDetailRepository.Entries;
            Assert.Contains(entries, entry => entry.Username == "John Doe" && entry.Password == "password123");
        }
        
        [Fact]
        public void AddLoginDetail_ShouldNotAddEntryWithInvalidUsername()
        {
            // Arrange
            var mockFileHelper = new Mock<IFileHelper>();
            var mockEncryptionHelper = new Mock<IEncryptionHelper>();
            var passwordManager = new PasswordManager(mockFileHelper.Object, mockEncryptionHelper.Object);
            
            // Login detail with invalid username
            var loginDetail = new LoginDetail("Google", "", "john@example.com", "password123", new List<SecurityQuestion>());

            // Assert
            Assert.Throws<ArgumentException>(() => passwordManager.LoginDetailRepository.Add(loginDetail));
        }
        
        #endregion
        
        #region BankDetail
        
        [Fact]
        public void AddBankDetail_ShouldAddEntry()
        {
            // Arrange
            var mockFileHelper = new Mock<IFileHelper>();
            var mockEncryptionHelper = new Mock<IEncryptionHelper>();
            var passwordManager = new PasswordManager(mockFileHelper.Object, mockEncryptionHelper.Object);
            var bankDetail = new BankDetail("ING", 1111111111, "John Doe", "password123");

            // Act
            passwordManager.BankDetailRepository.Add(bankDetail);

            // Assert
            var entries = passwordManager.BankDetailRepository.Entries;
            Assert.Contains(entries, entry => entry.Username == "John Doe" && entry.Password == "password123");
        }
        
        [Fact]
        public void AddBankDetail_ShouldNotAddEntryWithInvalidUsername()
        {
            // Arrange
            var mockFileHelper = new Mock<IFileHelper>();
            var mockEncryptionHelper = new Mock<IEncryptionHelper>();
            var passwordManager = new PasswordManager(mockFileHelper.Object, mockEncryptionHelper.Object);
            
            // Login detail with invalid username
            var bankDetail = new BankDetail("", 1111111111, "John Doe", "password123");

            // Assert
            Assert.Throws<ArgumentException>(() => passwordManager.BankDetailRepository.Add(bankDetail));
        }
        
        #endregion
        
        #region CreditCard
        
        [Fact]
        public void AddCreditCard_ShouldAddEntry()
        {
            // Arrange
            var mockFileHelper = new Mock<IFileHelper>();
            var mockEncryptionHelper = new Mock<IEncryptionHelper>();
            var passwordManager = new PasswordManager(mockFileHelper.Object, mockEncryptionHelper.Object);
            
            var creditCard = new CreditCard("John Doe", 1111111111, DateTime.Now, 1, "address123");

            // Act
            passwordManager.CreditCardRepository.Add(creditCard);

            // Assert
            var entries = passwordManager.CreditCardRepository.Entries;
            Assert.Contains(entries, entry => entry.Issuer == "John Doe" && entry.BillingAddress == "address123");
        }
        
        [Fact]
        public void AddCreditCard_ShouldNotAddEntryWithInvalidIssuer()
        {
            // Arrange
            var mockFileHelper = new Mock<IFileHelper>();
            var mockEncryptionHelper = new Mock<IEncryptionHelper>();
            var passwordManager = new PasswordManager(mockFileHelper.Object, mockEncryptionHelper.Object);
            
            // Login detail with invalid username
            var creditCard = new CreditCard("", 1111111111, DateTime.Now, 1, "address123");

            // Assert
            Assert.Throws<ArgumentException>(() => passwordManager.CreditCardRepository.Add(creditCard));
        }
        
        #endregion
    }
}