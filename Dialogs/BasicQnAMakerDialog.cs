using System;
using System.Configuration;

using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;

namespace Microsoft.Bot.Sample.QnABot
{
    // For more information about this template visit http://aka.ms/azurebots-csharp-qnamaker
    [Serializable]
    public class BasicQnAMakerDialog : QnAMakerDialog
    {
        // Go to https://qnamaker.ai and feed data, train & publish your QnA Knowledgebase.
        public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute(ConfigurationManager.AppSettings["QnASubscriptionKey"], ConfigurationManager.AppSettings["QnAKnowledgebaseId"])))  // If you're running this bot locally, make sure you have these appSettings in youe web.config
        {
        }
        protected override async Task RespondFromQnAMakerResultAsync(IDialogContext context, IMessageActivity message, QnAMakerResults result)
        {
            //var answer = result.Answers.First();
            //var  reply = "【質問】" + Environment.NewLine + answer.Questions + Environment.NewLine + "【回答】" + answer.Answer;
            //await context.PostAsync(reply);
            await context.PostAsync(message);
        }
    }
}
