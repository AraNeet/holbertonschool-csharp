using System;
using Xunit;
using InventoryLibrary;
using System.Collections.Generic;

namespace InventoryLibrary.Tests
{
    public class ItemTests
    {
        [Fact]
        public void Constructor_WithValidName_ShouldInitializeProperties()
        {
            // Arrange & Act
            var item = new Item("Test Item");
            
            // Assert
            Assert.Equal("Test Item", item.Name);
            Assert.Null(item.Description);
            Assert.Equal(0, item.Price);
            Assert.NotNull(item.Tags);
            Assert.Empty(item.Tags);
            
            // BaseClass properties
            Assert.NotNull(item.Id);
            Assert.NotEmpty(item.Id);
            Assert.True(item.DateCreated != default);
            Assert.True(item.DateUpdated != default);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void Constructor_WithInvalidName_ShouldThrowException(string invalidName)
        {
            // Arrange, Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => new Item(invalidName));
            Assert.Contains("Name is required", exception.Message);
        }

        [Fact]
        public void Price_ShouldRoundToTwoDecimalPlaces()
        {
            // Arrange
            var item = new Item("Test Item");
            
            // Act
            item.Price = 10.2345f;
            
            // Assert
            Assert.Equal(10.23f, item.Price);
        }

        [Fact]
        public void Tags_ShouldAddAndStoreValues()
        {
            // Arrange
            var item = new Item("Test Item");
            
            // Act
            item.Tags.Add("tag1");
            item.Tags.Add("tag2");
            
            // Assert
            Assert.Equal(2, item.Tags.Count);
            Assert.Contains("tag1", item.Tags);
            Assert.Contains("tag2", item.Tags);
        }

        [Fact]
        public void Description_ShouldStoreValue()
        {
            // Arrange
            var item = new Item("Test Item");
            
            // Act
            item.Description = "Test Description";
            
            // Assert
            Assert.Equal("Test Description", item.Description);
        }

        [Fact]
        public void Price_NegativeValues_ShouldBeAllowed()
        {
            // Arrange
            var item = new Item("Test Item");
            
            // Act
            item.Price = -10.5f;
            
            // Assert
            Assert.Equal(-10.5f, item.Price);
        }
    }
} 