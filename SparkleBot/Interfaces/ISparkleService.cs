namespace SparkleBot.Interfaces;

public interface ISparkleService
{
    Task Run();
    
    Task Stop();

    Task CreatePost();
}
