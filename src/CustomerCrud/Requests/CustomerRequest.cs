using CustomerCrud.Core;

namespace CustomerCrud.Requests;

public class CustomerRequest
{
    public string? Name { get; set; }
    public string? CPF { get; set; }
    public List<Transaction> Transactions { get; set; } = new();
}