using CustomerCrud.Core;

namespace CustomerCrud.Repositories;

public interface ICustomerRepository
{
    public IEnumerable<Customer> GetAll();

    public Customer? GetById(int id);

    public bool Create(Customer customer);

    public bool Update(int id, dynamic fields);

    public bool Delete(int id);

    public int GetNextIdValue();
}