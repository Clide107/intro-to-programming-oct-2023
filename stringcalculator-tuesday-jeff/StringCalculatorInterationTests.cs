
namespace StringCalculator;
public class StringCalculatorInterationTests
{
    private readonly StringCalculator _calculator;
    private readonly ILogger _logger;
    private readonly IWebService _webService;
    public StringCalculatorInterationTests()
    {
        _logger = Substitute.For<ILogger>();
        _calculator = new StringCalculator(_logger, _webService);
        _webService = Substitute.For<IWebService>();
    }

    [Theory]
    [InlineData("1")]
    public void WritesToLogger(string numbers)
    {
        // when 
        _calculator.Add(numbers);

        // then
        // Does "1" get written to the logger's write method?
        _logger.Received().Write(numbers);
    }

    [Fact]
    public void SendsMessageToApiIfLoggerFails()
    {
        _logger.When(m => m.Write(Arg.Any<string>())).Do(x => throw new LoggingException());

        _calculator.Add("999");
    }

}
