
// Erstelle mehrere Aufgabenobjekte

Task task3 = new Task()

Task task1 = new Task("Dokumentation schreiben", "Schreibe die Projektdokumentation bis zum Ende der Woche", new DateTime(2024, 07, 31), iscompleted;
Task task2 = new Task("Code-Review durchführen", "Überprüfe den Code des neuen Features", new DateTime(2024, 7, 15);

// Rufe die Beschreibungen ab und gib sie aus
Console.WriteLine(task1.GetTaskInfo());
Console.WriteLine(task2.GetTaskInfo());

// Markiere die erste Aufgabe als erledigt
task1.CompleteTask();
Console.WriteLine(task1.GetTaskInfo());

// Verlängere das Fälligkeitsdatum der zweiten Aufgabe
task2.ExtendDueDate(new DateTime(2024, 7, 10));
Console.WriteLine(task2.GetTaskInfo());
