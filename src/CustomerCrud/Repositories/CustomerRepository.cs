using JsonFlatFileDataStore;
using CustomerCrud.Core;

namespace CustomerCrud.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly IDataStore _db;

    public CustomerRepository(IDataStore db)
    {
        _db = db;
    }

    public IEnumerable<Customer> GetAll() => GetCollection().AsQueryable();

    public Customer? GetById(int id) => GetCollection().Find(r => r.Id == id).FirstOrDefault();

    public bool Create(Customer customer) => GetCollection().InsertOne(customer);

    public bool Update(int id, dynamic fields) => GetCollection().UpdateOne(id, fields);

    public bool Delete(int id) => GetCollection().DeleteOne(id);

    public int GetNextIdValue() => GetCollection().GetNextIdValue();

    private IDocumentCollection<Customer> GetCollection() =>
        _db.GetCollection<Customer>();
}