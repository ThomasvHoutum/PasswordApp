using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Managers;
using Xunit;

namespace DomainTest
{
    public class SearchManagerTest
    {
        #region LoginDetail
        
        [Fact]
        public void Search_ShouldReturnMatchingLoginDetails_WhenQueryIsFound()
        {
            // Arrange
            var searchManager = new SearchManager();
            var entries = new List<LoginDetail>
            {
                new LoginDetail("Google", "John Doe", "john@example.com", "password123", new List<SecurityQuestion>()),
                new LoginDetail("Facebook", "Jane Smith", "jane@example.com", "password456", new List<SecurityQuestion>()),
                new LoginDetail("Twitter", "Alice Johnson", "alice@example.com", "password789", new List<SecurityQuestion>())
            };

            var searchQuery = "John";

            // Act
            var result = searchManager.Search(entries, searchQuery);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, loginDetail => loginDetail.Username == "John Doe");
            Assert.Contains(result, loginDetail => loginDetail.Username == "Alice Johnson");
        }

        [Fact]
        public void Search_ShouldReturnEmptyListOfLoginDetails_WhenQueryIsNotFound()
        {
            // Arrange
            var searchManager = new SearchManager();
            var entries = new List<LoginDetail>
            {
                new LoginDetail("Google", "John Doe", "john@example.com", "password123", new List<SecurityQuestion>()),
                new LoginDetail("Facebook", "Jane Smith", "jane@example.com", "password456", new List<SecurityQuestion>()),
                new LoginDetail("Twitter", "Alice Johnson", "alice@example.com", "password789", new List<SecurityQuestion>())
            };
    
            var searchQuery = "nonexistent";
    
            // Act
            var result = searchManager.Search(entries, searchQuery);
    
            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
        
        #endregion
        
        #region BankDetail
        
        [Fact]
        public void Search_ShouldReturnMatchingBankDetails_WhenQueryIsFound()
        {
            // Arrange
            var searchManager = new SearchManager();
            var entries = new List<BankDetail>
            {
                new BankDetail("ING", 1111111111, "John Doe", "password123"),
                new BankDetail("ABN", 2222222222, "Jane Smith", "password456"),
                new BankDetail("Bunq", 3333333333, "Alice Johnson", "password789")
            };

            var searchQuery = "John";

            // Act
            var result = searchManager.Search(entries, searchQuery);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, bankDetail => bankDetail.Username == "John Doe");
            Assert.Contains(result, bankDetail => bankDetail.Username == "Alice Johnson");
        }

        [Fact]
        public void Search_ShouldReturnEmptyListOfBankDetails_WhenQueryIsNotFound()
        {
            // Arrange
            var searchManager = new SearchManager();
            var entries = new List<BankDetail>
            {
                new BankDetail("ING", 1111111111, "John Doe", "password123"),
                new BankDetail("ABN", 2222222222, "Jane Smith", "password456"),
                new BankDetail("Bunq", 3333333333, "Alice Johnson", "password789")
            };
    
            var searchQuery = "nonexistent";
    
            // Act
            var result = searchManager.Search(entries, searchQuery);
    
            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
        
        #endregion
        
        #region CreditCard
        
        [Fact]
        public void Search_ShouldReturnMatchingCreditCards_WhenQueryIsFound()
        {
            // Arrange
            var searchManager = new SearchManager();
            var entries = new List<CreditCard>
            {
                new CreditCard("John Doe", 1111111111, DateTime.Now, 1, "address123"),
                new CreditCard("Jane Smith", 2222222222, DateTime.Now, 2, "address456"),
                new CreditCard("Alice Johnson", 3333333333, DateTime.Now, 3, "address789")
            };

            var searchQuery = "John";

            // Act
            var result = searchManager.Search(entries, searchQuery);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Contains(result, bankDetail => bankDetail.Issuer == "John Doe");
            Assert.Contains(result, bankDetail => bankDetail.Issuer == "Alice Johnson");
        }

        [Fact]
        public void Search_ShouldReturnEmptyListOfCreditCards_WhenQueryIsNotFound()
        {
            // Arrange
            var searchManager = new SearchManager();
            var entries = new List<CreditCard>
            {
                new CreditCard("John Doe", 1111111111, DateTime.Now, 1, "address123"),
                new CreditCard("Jane Smith", 2222222222, DateTime.Now, 2, "address456"),
                new CreditCard("Alice Johnson", 3333333333, DateTime.Now, 3, "address789")
            };
    
            var searchQuery = "nonexistent";
    
            // Act
            var result = searchManager.Search(entries, searchQuery);
    
            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }
        
        #endregion
    }
}