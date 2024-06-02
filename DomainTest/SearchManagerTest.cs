using System.Collections.Generic;
using Domain.Managers;
using Shared.Dtos;
using Xunit;

namespace Domain.Test
{
    public class SearchManagerTest
    {

        [Fact]
        public void Search_ShouldReturnMatchingEntries_WhenQueryIsFound()
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
        public void Search_ShouldReturnEmptyList_WhenQueryIsNotFound()
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
    }
}