namespace MyProject;

public class QueueLister(IAmazonSQS sqsClient) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        do
        {
            var queues = await sqsClient.ListQueuesAsync("", stoppingToken);
            if (queues.QueueUrls.Count == 0)
            {
                Console.WriteLine("No queues found");
            }
            else
            {
                foreach (var queue in queues.QueueUrls)
                {
                    Console.WriteLine($"Found queue {queue}");
                }
            }

            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
        } while (!stoppingToken.IsCancellationRequested);
    }
}