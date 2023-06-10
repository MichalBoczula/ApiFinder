using Polly;
using Polly.Extensions.Http;

namespace ApiFinder.Infrastructure.Policies.ExternalServices
{
    public class ExternalServiceRequestHandlerPolicy
    {
        public static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
        {
            return HttpPolicyExtensions.HandleTransientHttpError()
                .WaitAndRetryAsync(5,
                    retryAttempt => TimeSpan.FromMilliseconds(Math.Pow(2, retryAttempt) * 1000),
                    (_, waitingTime) =>
                    {
                        Console.WriteLine($"Retrying after {waitingTime}");
                    });
        }

        public static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
        {
            return HttpPolicyExtensions
                .HandleTransientHttpError()
                .CircuitBreakerAsync(3, TimeSpan.FromSeconds(60));
        }
    }
}
