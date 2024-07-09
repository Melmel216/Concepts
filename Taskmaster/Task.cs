
namespace Taskmaster
{
    public class Tasky
    {
        // Eigenschaften kommen hier hin:

        internal string Title { get; set; }
        internal string Description { get; set; }
        internal DateTime DueDate { get; set; }
        internal bool IsCompleted { get; set; }

        // Konstruktor soll hier implementiert werden:

        public Tasky(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
        }

        // Beschreibung der Aufgabe
        public string GetTaskInfo()
        {
            return $"'Title': {Title}, Beschreibung: {Description}, Fällig bis: {DueDate}, Erledigt: {IsCompleted}";
        }

        // Markierung der Aufgabe als erledigt
        public void CompleteTask()
        {
            IsCompleted = true ;
        }

        // Verlängerung des Fälligkeitsdatums
        public void ExtendDueDate(DateTime newDueDate)
        {
            DueDate = newDueDate;
        }
    }
}
