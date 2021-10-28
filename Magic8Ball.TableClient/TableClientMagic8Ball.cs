using Magic8Ball.Shared;
using System;
using System.Threading.Tasks;

namespace Magic8Ball.TableClient
{
    public class TableClientMagic8Ball : Magic8BallData, IMagic8BallService
    {
        /// <summary>
        /// Ask the Magic 8 Ball a Question
        /// </summary>
        /// <param name="Question">Yes/No question to ask</param>
        /// <returns>This Magic 8 Ball object with resulting Question, Answer and Type</returns>
        public async Task<Magic8BallData> AskAsync(string Question)
        {
            // Catch and log any errors
            try
            {
                // TODO: Get Classic Answer from the Azure Data Table
                // e.g. https://storageaccountmagic8d46.table.core.windows.net/Magic8BallAnswers?$filter=(PartitionKey%20eq%20'Classic')&$select=Type,Answer&st=2021-10-27T22%3A30%3A38Z&se=2021-10-28T22%3A30%3A38Z&sp=r&sv=2018-03-28&tn=magic8ballanswers&sig=UWGRQ3hiwv2%2FZhGiF4IitW3vg8A6S40fo%2BUFB%2BqWyHQ%3D
                // TODO: Then parse them into a list of answers and get and return a random answer from the list
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // Wrap and rethrow the error back to caller with some context
                throw new Exception($"Failed asking the Magic 8 Ball '{Question}'.", ex);
            }
        }
    }
}
