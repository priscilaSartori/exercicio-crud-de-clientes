namespace CustomerCrud.Test.Test;

public class CustomerControllerTestTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }

    [Trait("Category", "1. Crie o método `GetAll`")]
    [Fact(DisplayName = "1. Crie o método `GetAll`")]
    public async void TestGetAllTest()
    {
        Func<Task> act = () => _instance.GetAllTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest2 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest2(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }

    [Trait("Category", "2. Crie o método `GetById`")]
    [Fact(DisplayName = "2. Crie o método `GetById`")]
    public async void TestGetByIdTest()
    {
        Func<Task> act = () => _instance.GetByIdTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest3 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest3(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }
    [Trait("Category", "3. Crie o método `Create`")]
    [Fact(DisplayName = "3. Crie o método `Create`")]
    public async void TestCreateTest()
    {
        Func<Task> act = () => _instance.CreateTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest4 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest4(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }
    [Trait("Category", "4. Crie o método `Update`")]
    [Fact(DisplayName = "4. Crie o método `Update`")]
    public async void TestUpdateTest()
    {
        Func<Task> act = () => _instance.UpdateTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}
public class CustomerControllerTestTest5 : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly CustomersControllerTest _instance;

    public CustomerControllerTestTest5(WebApplicationFactory<Program> factory)
    {
        _instance = new CustomersControllerTest(factory);
    }
    [Trait("Category", "5. Crie o método `Delete`")]
    [Fact(DisplayName = "5. Crie o método `Delete`")]
    public async void TestDeleteTest()
    {
        Func<Task> act = () => _instance.DeleteTest();

        await act.Should().NotThrowAsync<NotImplementedException>();
        await act.Should().NotThrowAsync<XunitException>();
    }
}