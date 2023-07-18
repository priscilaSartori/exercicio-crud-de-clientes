// O método GetAll deve ser acessível por uma requisição GET na rota "/controller"
// Como a rota usada é a mesma que a rota base, apenas é necessário utilizar neste método o atributo que represente o verbo HTTP correto, sem nenhum parâmetro a mais.
// O método GetAll deve responder com um ActionResult (ou derivado) contendo o status 200 (Ok), caso a leitura ocorra corretamente
// A resposta do método GetAll deve retornar em seu corpo todas as entradas do banco
// O método GetAllTest deve conter os testes para o método GetAll:
// Uma chamada GET para a rota "/customers" utilizando o _client
// Um mock do método GetAll() do repositório, configurado usando o _repositoryMock
// Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo 200 (Ok)
// Uma verificação de que o conteúdo da resposta é equivalente ao objeto retornado pelo mock
// Uma verificação de que o método mockado foi chamado uma única vez

using Microsoft.AspNetCore.Mvc;
using CustomerCrud.Core;
using CustomerCrud.Requests;
using CustomerCrud.Repositories;

namespace CustomerCrud.Controllers;

[ApiController]
[Route("customers")]
public class CustomerController : ControllerBase
{
  private readonly ICustomerRepository _repository;

  public CustomerController(ICustomerRepository repository)
  {
    _repository = repository;
  }

  [HttpGet]
  public ActionResult GetAll()
  {
    var customers = _repository.GetAll();
    return Ok(customers);
  }

  [HttpGet("{id}", Name = "GetById")]
  public ActionResult GetById(int id)
  {
    var customer = _repository.GetById(id);

    if (customer == null) return NotFound("Customer not found");

    return Ok(customer);
  }

  [HttpPost]
  public ActionResult Create(CustomerRequest request)
  {
    var id = _repository.GetNextIdValue();

    var customer = new Customer(id, request);
    _repository.Create(customer);

    return CreatedAtAction("GetById", new { id = customer.Id }, customer);
  }
}
