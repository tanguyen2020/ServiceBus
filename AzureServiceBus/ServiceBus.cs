using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Newtonsoft.Json;

namespace AzureServiceBus
{
    public static class ServiceBus
    {
        public static async Task SendMessageAsync(string connectString, string serviceBusName, string body)
        {
            var message = new Message()
            {
                MessageId = $"{1}",
                Body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(body)),
                ScheduledEnqueueTimeUtc = DateTime.UtcNow.AddMinutes(1), //Schedule send message
                ContentType = "application/json"
            };
            IQueueClient queueClient = new QueueClient(connectString, serviceBusName);
            await queueClient.SendAsync(message);
            await queueClient.CloseAsync();
        }
    }
}
