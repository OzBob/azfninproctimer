using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace CronJobs
{
    public class GoodNcron
    {
        [FunctionName("GoodNcron")]
        public void Run([TimerTrigger("0 */11 * * * *"
#if DEBUG
            , RunOnStartup = true
#endif
            )]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function with nCRON expression '0 */11 * * * *' executed at: {DateTime.Now}");
        }
    }
}
