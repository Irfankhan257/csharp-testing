using Xunit;
using Moq;
using AddNumbersApp;

namespace AddNumbersApp.Tests
{
    public class AddNumbersTests
    {
        [Fact]
        public void AddTwoNumbers_ShouldReturnSum_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = Program.AddTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void SubtractTwoNumbers_ShouldReturnDifference_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            int result = Program.SubtractTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void MultiplyTwoNumbers_ShouldReturnProduct_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = Program.MultiplyTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void DivideTwoNumbers_ShouldReturnQuotient_WhenGivenTwoIntegers()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            double result = Program.DivideTwoNumbers(num1, num2);

            // Assert
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void DivideTwoNumbers_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            // Arrange
            int num1 = 10;
            int num2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Program.DivideTwoNumbers(num1, num2));
        }
    }
}
