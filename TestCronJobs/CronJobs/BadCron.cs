using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CronJobs
{
    public class BadCron
    {
        [FunctionName("BadCron")]
        public void Run([TimerTrigger("* */11 * * *"
#if DEBUG
            , RunOnStartup = true
#endif
            )]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function with CRON expression '* */11 * * *' executed at: {DateTime.Now}");
        }
    }
}
