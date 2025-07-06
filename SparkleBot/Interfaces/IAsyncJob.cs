namespace SparkleBot.Jobs;

public interface IAsyncJob
{
    Task ExecuteAsync();
}
