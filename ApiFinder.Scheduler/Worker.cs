using Hangfire;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace ApiFinder.Scheduler
{
    public class Worker : BackgroundService
    {
        private readonly IRecurringJobManager _recurringJobManager;

        public Worker(IRecurringJobManager recurringJobManager)
        {
            _recurringJobManager = recurringJobManager;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //_recurringJobManager.AddOrUpdate("jobId", () => Debug.WriteLine("Drugi Test Ziom _________________________________________"), Cron.Minutely);
        }
    }
}