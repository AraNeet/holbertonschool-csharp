using System;
using Xunit;
using InventoryLibrary;

namespace InventoryLibrary.Tests
{
    public class BaseClassTests
    {
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange & Act
            var baseObject = new BaseClass();
            
            // Assert
            Assert.NotNull(baseObject.Id);
            Assert.NotEmpty(baseObject.Id);
            Assert.True(baseObject.DateCreated != default);
            Assert.True(baseObject.DateUpdated != default);
            
            // Compare date values to ensure they're roughly the same time
            // Without requiring exact equality (which can fail due to microsecond differences)
            var timeDifference = baseObject.DateCreated - baseObject.DateUpdated;
            Assert.True(Math.Abs(timeDifference.TotalSeconds) < 1, "DateCreated and DateUpdated should be set to similar times");
        }

        [Fact]
        public void Constructor_ShouldGenerateUniqueIds()
        {
            // Arrange & Act
            var baseObject1 = new BaseClass();
            var baseObject2 = new BaseClass();
            
            // Assert
            Assert.NotEqual(baseObject1.Id, baseObject2.Id);
        }

        [Fact]
        public void DateCreated_ShouldBeSetToCurrentTime()
        {
            // Arrange
            var beforeCreation = DateTime.Now.AddSeconds(-1);
            
            // Act
            var baseObject = new BaseClass();
            var afterCreation = DateTime.Now.AddSeconds(1);
            
            // Assert
            Assert.True(baseObject.DateCreated >= beforeCreation);
            Assert.True(baseObject.DateCreated <= afterCreation);
        }

        [Fact]
        public void DateUpdated_ShouldBeSetToCurrentTime()
        {
            // Arrange
            var beforeCreation = DateTime.Now.AddSeconds(-1);
            
            // Act
            var baseObject = new BaseClass();
            var afterCreation = DateTime.Now.AddSeconds(1);
            
            // Assert
            Assert.True(baseObject.DateUpdated >= beforeCreation);
            Assert.True(baseObject.DateUpdated <= afterCreation);
        }
    }
} 