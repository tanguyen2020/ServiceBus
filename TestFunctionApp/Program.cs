using AzureServiceBus;
using System;
using System.Threading.Tasks;

namespace TestFunctionApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var connectionString = "Endpoint=sb://azcacaufd2devasb01.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=u6aWsJ5lcLrzKb1LB6z0aAeFpWrhpB6kkBegGqx+8Ic=";
            var queueName = "notificationqueue_pod6_tanguyen";
            string body = $"This message has ScheduledEnqueueTimeUtc property set. It will appear in queue after 2 minutes. Current date/time is: { DateTime.UtcNow}";
            await ServiceBus.SendMessageAsync(connectionString, queueName, body);
            Console.WriteLine("Starting......");
            Console.ReadLine();
        }
    }
}
