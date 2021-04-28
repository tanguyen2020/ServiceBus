using System;
using AzureServiceBus.Common;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionSendMessage
{
    public static class MessageHandler
    {
        [FunctionName("SendMessage")]
        public static void Run(
            [ServiceBusTrigger("%NotificationQueueName%", Connection = "ConnectionString")]
            Message myQueueItem, 
            ILogger log)
        {
            string mes = MessageConverter.TextMessage(myQueueItem);
            log.LogInformation($"{mes}");
            //log.LogInformation($"Current Date: {DateTime.UtcNow}");
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
