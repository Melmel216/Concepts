using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskmaster
{
    internal class Task
    {
        // Eigenschaften kommen hier hin:

        internal string Title { get; set; }
        internal string Description { get; set; }
        internal DateTime DueDate { get; set; }
        internal bool IsCompleted { get; set; }

        // Konstruktor soll hier implementiert werden:

        public Task(string title, string description, DateTime dueDate, bool isCompleted)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
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
