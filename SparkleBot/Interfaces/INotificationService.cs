namespace SparkleBot.Interfaces;

public interface INotificationService
{
    public Task Notify(string title, string message, int priority = 0);
}
