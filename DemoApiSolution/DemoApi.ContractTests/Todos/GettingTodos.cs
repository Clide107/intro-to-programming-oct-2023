using Alba;

namespace DemoApi.ContractTests.Todos;
public class GettingTodos
{

    [Fact]
    public async Task CanGetATodo()
    {
        var host = await AlbaHost.For<Program>();

        await host.Scenario(api =>
        {
            api.Get.Url("/todo-list/6be9b506-0918-4c8f-89c5-a619d70db30f");
            api.StatusCodeShouldBeOk();
        });

        await host.Scenario(api =>
        {
            api.Get.Url("/todo-list/" + Guid.NewGuid().ToString());
            api.StatusCodeShouldBe(404);

        });
    }
}
