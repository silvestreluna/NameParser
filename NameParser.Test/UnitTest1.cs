using System;
using Xunit;

namespace NameParser.Test
{
    public class NameParsingTests
    {
        [Fact]
        public void FirstAndLastNameShouldBeParsedAccurately()
        {
            // Arrange
            var name = "Martin Cross";
            var parser = new Parser();

            // Act
            var result = parser.ParseName(name);

            // Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);
        }

        [Fact]
        public void ThreePartNameShouldBeParsedAccurately()
        {
            // Arrange
            var name = "Martin Zacharia Cross";
            var parser = new Parser();

            // Act 
            var result = parser.ParseName(name);

            // Assert
            Assert.Equal("Martin", result.FirstName);
            Assert.Equal("Cross", result.LastName);

        }
    }
}
