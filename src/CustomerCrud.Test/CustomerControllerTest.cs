using CustomerCrud.Core;
using CustomerCrud.Repositories;
using CustomerCrud.Requests;

namespace CustomerCrud.Test;

public class CustomersControllerTest : IClassFixture<WebApplicationFactory<Program>>
{
  private readonly HttpClient _client;
  private readonly Mock<ICustomerRepository> _repositoryMock;

  public CustomersControllerTest(WebApplicationFactory<Program> factory)
  {
    _repositoryMock = new Mock<ICustomerRepository>();

    _client = factory.WithWebHostBuilder(builder =>
    {
      builder.ConfigureServices(services =>
          {
            services.AddScoped<ICustomerRepository>(st => _repositoryMock.Object);
          });
    }).CreateClient();
  }

  [Fact]
  public async Task GetAllTest()
  {
    var customers = AutoFaker.Generate<Customer>(3);
    _repositoryMock.Setup(r => r.GetAll()).Returns(customers);

    var response = await _client.GetAsync("/customers");
    var content = await response.Content.ReadFromJsonAsync<IEnumerable<Customer>>();

    response.StatusCode.Should().Be(HttpStatusCode.OK);
    content.Should().BeEquivalentTo(customers);

    _repositoryMock.Verify(r => r.GetAll(), Times.Once);
  }

  [Fact]
  public async Task GetByIdTest()
  {
    throw new NotImplementedException();
  }

  [Fact]
  public async Task CreateTest()
  {
    throw new NotImplementedException();
  }

  [Fact]
  public async Task UpdateTest()
  {
    throw new NotImplementedException();
  }

  [Fact]
  public async Task DeleteTest()
  {
    throw new NotImplementedException();
  }
}