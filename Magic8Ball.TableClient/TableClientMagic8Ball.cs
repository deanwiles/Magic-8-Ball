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
                // TODO: Get Classic Answer from the Azure Data Table; GetConnectionStrings("Magic8BallDB")
                // e.g. https://storageaccountmagic8d46.table.core.windows.net/Magic8BallAnswers?$filter=(PartitionKey%20eq%20'Classic')&$select=Type,Answer&sv=2020-08-04&ss=t&srt=o&sp=rl&se=2030-10-31T08:00:00Z&st=2021-10-29T18:40:26Z&spr=https&sig=VdvRqJWo5DL%2BAiB%2FyxW9pPjWpzIRjTm%2FHS6xVLeNE2I%3D?sv=2020-08-04&ss=t&srt=o&sp=rl&se=2030-10-31T08:00:00Z&st=2021-10-29T18:40:26Z&spr=https&sig=VdvRqJWo5DL%2BAiB%2FyxW9pPjWpzIRjTm%2FHS6xVLeNE2I%3D
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
