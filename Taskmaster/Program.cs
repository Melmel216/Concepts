
// Erstelle mehrere Aufgabenobjekte

using System.Threading.Tasks;
using Taskmaster;


// Erstelle mehrere Aufgabenobjekte
Tasky task1 = new Tasky("Dokumentation schreiben", "Schreibe die Projektdokumentation bis zum Ende der Woche", new DateTime(2024, 7, 7));
Tasky task2 = new Tasky("Code-Review durchführen", "Überprüfe den Code des neuen Features", new DateTime(2024, 7, 5));
Tasky task3 = new Tasky("Neue Klasse anlegen", "Lege eine neue Klasse für den Taskmaster an", new DateTime(2024, 7, 12));

// Rufe die Beschreibungen ab und gib sie aus
Console.WriteLine(task1.GetTaskInfo());
Console.WriteLine(task2.GetTaskInfo());
Console.WriteLine(task3.GetTaskInfo());

// Markiere die erste Aufgabe als erledigt
task1.CompleteTask();
Console.WriteLine(task1.GetTaskInfo());

task3.CompleteTask();
Console.WriteLine(task3.GetTaskInfo());

// Verlängere das Fälligkeitsdatum der zweiten Aufgabe
task2.ExtendDueDate(new DateTime(2024, 7, 10));
Console.WriteLine(task2.GetTaskInfo());