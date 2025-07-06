namespace SparkleBot.Interfaces;

public interface IJournalService
{
    Task SaveJournal(string title, string entry);
}
