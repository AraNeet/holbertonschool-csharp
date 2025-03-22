using System;
using Xunit;
using InventoryLibrary;

namespace InventoryLibrary.Tests
{
    public class InventoryTests
    {
        [Fact]
        public void Constructor_WithValidArguments_ShouldInitializeProperties()
        {
            // Arrange & Act
            var inventory = new Inventory("user123", "item456");
            
            // Assert
            Assert.Equal("user123", inventory.UserId);
            Assert.Equal("item456", inventory.ItemId);
            Assert.Equal(1, inventory.Quantity); // Default quantity
            
            // BaseClass properties
            Assert.NotNull(inventory.Id);
            Assert.NotEmpty(inventory.Id);
            Assert.True(inventory.DateCreated != default);
            Assert.True(inventory.DateUpdated != default);
        }

        [Theory]
        [InlineData(null, "item123")]
        [InlineData("", "item123")]
        [InlineData("   ", "item123")]
        public void Constructor_WithInvalidUserId_ShouldThrowException(string invalidUserId, string itemId)
        {
            // Arrange, Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Inventory(invalidUserId, itemId));
            Assert.Contains("User ID is required", exception.Message);
        }

        [Theory]
        [InlineData("user123", null)]
        [InlineData("user123", "")]
        [InlineData("user123", "   ")]
        public void Constructor_WithInvalidItemId_ShouldThrowException(string userId, string invalidItemId)
        {
            // Arrange, Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Inventory(userId, invalidItemId));
            Assert.Contains("Item ID is required", exception.Message);
        }

        [Fact]
        public void Quantity_SetValidValue_ShouldUpdateProperty()
        {
            // Arrange
            var inventory = new Inventory("user123", "item456");
            
            // Act
            inventory.Quantity = 10;
            
            // Assert
            Assert.Equal(10, inventory.Quantity);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        public void Quantity_SetNegativeValue_ShouldThrowException(int negativeQuantity)
        {
            // Arrange
            var inventory = new Inventory("user123", "item456");
            
            // Act & Assert
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => inventory.Quantity = negativeQuantity);
            Assert.Contains("Quantity cannot be less than 0", exception.Message);
        }

        [Fact]
        public void Quantity_SetZeroValue_ShouldBeAllowed()
        {
            // Arrange
            var inventory = new Inventory("user123", "item456");
            
            // Act
            inventory.Quantity = 0;
            
            // Assert
            Assert.Equal(0, inventory.Quantity);
        }

        [Fact]
        public void TwoInventories_ShouldHaveDifferentIds()
        {
            // Arrange
            var inventory1 = new Inventory("user1", "item1");
            var inventory2 = new Inventory("user2", "item2");
            
            // Assert
            Assert.NotEqual(inventory1.Id, inventory2.Id);
        }
    }
} 