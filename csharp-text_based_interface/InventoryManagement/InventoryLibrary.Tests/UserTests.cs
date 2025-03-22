using System;
using Xunit;
using InventoryLibrary;

namespace InventoryLibrary.Tests
{
    public class UserTests
    {
        [Fact]
        public void Constructor_WithValidName_ShouldInitializeProperties()
        {
            // Arrange & Act
            var user = new User("John Doe");
            
            // Assert
            Assert.Equal("John Doe", user.Name);
            
            // BaseClass properties
            Assert.NotNull(user.Id);
            Assert.NotEmpty(user.Id);
            Assert.True(user.DateCreated != default);
            Assert.True(user.DateUpdated != default);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_WithInvalidName_ShouldThrowException(string invalidName)
        {
            // Arrange, Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new User(invalidName));
            Assert.Contains("Name is required", exception.Message);
        }

        [Fact]
        public void Name_ShouldBeUpdatable()
        {
            // Arrange
            var user = new User("John Doe");
            
            // Act
            user.Name = "Jane Smith";
            
            // Assert
            Assert.Equal("Jane Smith", user.Name);
        }

        [Fact]
        public void TwoUsers_ShouldHaveDifferentIds()
        {
            // Arrange
            var user1 = new User("User One");
            var user2 = new User("User Two");
            
            // Assert
            Assert.NotEqual(user1.Id, user2.Id);
        }
    }
} 