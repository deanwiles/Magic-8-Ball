namespace Magic8Ball.AITests
{
    using System;
    using System.Threading.Tasks;
    using Magic8Ball.AI;
    using Xunit;

    public class AIMagic8BallTests
    {
        private readonly AIMagic8Ball _testClass;

        public AIMagic8BallTests()
        {
            _testClass = new AIMagic8Ball();
        }

        [Fact]
        public async Task CanCallAskAsync()
        {
            // Arrange
            var Question = "TestValue757066526";

            // Act
            var result = await _testClass.AskAsync(Question);

            // Assert non-empty Answer received
            Assert.False(string.IsNullOrEmpty(result.Answer));
        }

        [Theory]
        //[InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public async Task CannotCallAskAsyncWithInvalidQuestion(string value)
        {
            await Assert.ThrowsAsync<Exception>(() => _testClass.AskAsync(value));
        }

        [Fact]
        public async Task AskAsyncPerformsMapping()
        {
            // Arrange
            var Question = "TestValue533726191";

            // Act
            var result = await _testClass.AskAsync(Question);

            // Assert
            Assert.Same(Question, result.Question);
        }
    }
}