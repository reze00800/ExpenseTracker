using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public int Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
