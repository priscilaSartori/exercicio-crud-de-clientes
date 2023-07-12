using CustomerCrud.Requests;

namespace CustomerCrud.Core;

public class Transaction
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public Transaction(decimal amount)
    {
        Amount = amount;
    }

    public Transaction() { }
}