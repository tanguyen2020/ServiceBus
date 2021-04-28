using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TimerTriggerFunction
{
    public static class TimerHandler
    {
        [FunctionName("ScheduleTimer")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation("Timer Starting..........");
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
