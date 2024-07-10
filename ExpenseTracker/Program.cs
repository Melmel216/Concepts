using ExpenseTracker;


//Lösch-Funktion:
//Funktion für getIndex erstellt
//Case 2 erledigt, fehlt nur die Anzeige, welche Expense gelöscht wurde
//
//Print-Expenses-Funktion erstellt für Anzeige aller Expenses

int getIndex(string prompt)     //Funktionssignatur
{
    Console.WriteLine(prompt);
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
}

List<Expense> expenses = new();
do
{
    Console.WriteLine("---ExpensesTracker---");

    //Console.WriteLine("Du hast folgende Expenses eingetragen:");
    //foreach (Expense exp in expenses)
    //{
    //  //Sollte € anzeigen, zeigt stattdessen "?" -> font in konsole ändern?
    //  Console.WriteLine($"\t{exp.Name}: {exp.Price}€");
    //}
    PrintExpenses("Du hast folgende Expenses eingetragen:");

    //Summe aller Expenses als Übersicht anzeigen 
    decimal expensesSum = Expense.ExpensesSum(expenses);
    Console.WriteLine($"Summe aller Ausgaben:\t" + expensesSum);
    //Menü:
    Console.WriteLine();
    Console.WriteLine("Was willst du tun?");
    Console.WriteLine("\t1. Neue Ausgabe angeben.");
    Console.WriteLine("\t2. Eine Ausgabe löschen.");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("neu");
            Console.WriteLine("Wofür hast du Geld ausgegeben? (Expense-Name)");
            var name = Console.ReadLine();
            Console.WriteLine("Wie viel hast du ausgegeben? (Expense-Price, eg. 420,69)");
            var price = Console.ReadLine();
            //Error-Checking: Was wenn User eine Zeichenkette (eg. Buxtehude) eingibt?
            var decimalPrice = decimal.Parse(price);
            Console.WriteLine("In welche Kategorie willst du diese Expense einordnen?");
            var category = Console.ReadLine();
            var newExpense = new Expense(name, decimalPrice, category);
            expenses.Add(newExpense);
            Console.WriteLine($"Du hast folgende Expense erstellt: ");
            Console.WriteLine($"\tname: {newExpense.Name}");
            Console.WriteLine($"\tprice: {newExpense.Price}");
            Console.WriteLine($"\tcategory: {newExpense.Category}");
            break;
        case "2":
            //Entfernen einer falsch-eingetragenen Expense
            Console.WriteLine("entfernen");
            int expenseIndex = getIndex("Welche Ausgabe möchtest du löschen?");

            //string expenseToRemove = string.Parse(expenses[expenseIndex]);
            expenses.RemoveAt(expenseIndex);

            //Console.WriteLine($"GELÖSCHT:  {expenseToRemove}");
            
            break;
    }
    Thread.Sleep(2000);
    Console.Clear();
} while (true);


void PrintExpenses(string prompt)   //kein static, weil gehört zu Objekt?
{
    Console.WriteLine(prompt);
    foreach (Expense exp in expenses)
    {
        //Sollte € anzeigen, zeigt stattdessen "?" -> font in konsole ändern?
        Console.WriteLine($"\t{exp.Name}: {exp.Price}€");
    }
}