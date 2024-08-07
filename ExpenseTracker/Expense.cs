﻿namespace ExpenseTracker
{
    internal class Expense
    {
        //Properties
        internal string Name { get; set; }
        internal decimal Price { get; set; }
        internal string Category { get; set; }
        internal DateTime CreatedAt { get; set; }

        public Expense(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
            CreatedAt = DateTime.Now;
        }

        public static decimal ExpensesSum(List<Expense> expenses)
        {
            decimal sum = 0;

            for (int i = 0; i < expenses.Count; i++)
            {
                sum = sum + expenses[i].Price;
            }
            return sum;
        }
    }
}
