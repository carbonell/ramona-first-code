using System;
using Xunit;

namespace ramona_first_code
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Can_Add_EmptyString()
        {
            // Arrange
            var calculator = new StringCalculator();

            // Act
            int result = calculator.Add("");

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Can_Add_SingleNumber()
        {
            // Arrange
            var calculator = new StringCalculator();

            // Act
            int result = calculator.Add("2");

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Can_Add_TwoNumbers()
        {
            // Arrange
            var calculator = new StringCalculator();

            // Act
            int result = calculator.Add("2,2");

            // Assert
            Assert.Equal(4, result);
        }
    }
}
