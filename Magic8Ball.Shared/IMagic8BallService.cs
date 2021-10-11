using System.Threading.Tasks;

namespace Magic8Ball.Shared
{
     public interface IMagic8BallService
    {
        /// <summary>
        /// Ask the Magic 8 Ball a Question
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <returns>The Magic 8 Ball object with resulting Question, Answer and Type</returns>
        public Task<Magic8BallData> AskAsync(string Question);
    }
}
