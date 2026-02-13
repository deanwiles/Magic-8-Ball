namespace Magic8Ball.ClassicTests
{
    using Magic8Ball.Classic;
    using Magic8Ball.Shared;
    using System;
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using Xunit;

    public class ClassicMagic8BallTests
    {
        private readonly ClassicMagic8Ball _testClass;
        private readonly PredefinedMagicAnswers _magicAnswers;

        public ClassicMagic8BallTests()
        {
            _magicAnswers = new PredefinedMagicAnswers(new ReadOnlyCollection<MagicAnswer>([
                new MagicAnswer
                {
                    Answer = "TestValue1244556571",
                    Type = AnswerType.Positive
                },
                new MagicAnswer
                {
                    Answer = "TestValue1310834092",
                    Type = AnswerType.Negative
                },
                new MagicAnswer
                {
                    Answer = "TestValue1829202959",
                    Type = AnswerType.Positive
                }
            ]));
            _testClass = new ClassicMagic8Ball(_magicAnswers);
        }

        [Fact]
        public void CanConstruct()
        {
            // Act
            var instance = new ClassicMagic8Ball();

            // Assert
            Assert.NotNull(instance);

            // Act
            instance = new ClassicMagic8Ball(_magicAnswers);

            // Assert
            Assert.NotNull(instance);
        }

        [Fact]
        public async Task CanCallAskAsync()
        {
            // Arrange
            var Question = "TestValue2106525994";

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
            var Question = "TestValue1484122324";

            // Act
            var result = await _testClass.AskAsync(Question);

            // Assert
            Assert.Same(Question, result.Question);
        }
    }
}