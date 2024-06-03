using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Managers;
using Infrastructure.Helpers;
using Xunit;

namespace Domain.Test
{
    public class PasswordManagerTest
    {
        [Fact]
        public void AddLoginDetail_ShouldAddEntry()
        {
            // Arrange
            var passwordManager = new PasswordManager(new FileHelper(), new EncryptionHelper());
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
            var passwordManager = new PasswordManager(new FileHelper(), new EncryptionHelper());
            
            // Login detail with invalid username
            var loginDetail = new LoginDetail("Google", "", "john@example.com", "password123", new List<SecurityQuestion>());

            // Assert
            Assert.Throws<ArgumentException>(() => passwordManager.LoginDetailRepository.Add(loginDetail));
        }
    }
}