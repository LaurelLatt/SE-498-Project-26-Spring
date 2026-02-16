using Project498.WebApi.Services;

namespace Project498.WebApi.Tests;

public class StringServiceTests
{
    private readonly StringService _stringService = new();

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("a", "a")]
    [InlineData("racecar", "racecar")]
    [InlineData("hello world", "dlrow olleh")]
    [InlineData("hello  world", "dlrow  olleh")]
    [InlineData(" hello world", "dlrow olleh ")]
    [InlineData("hello world ", " dlrow olleh")]
    public void Reverse_WithVariousInputs_ReturnsExpectedResult(string? input, string expected)
    {
        var result = _stringService.Reverse(input!);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("", "")] // empty
    [InlineData(" ", " ")] // whitespace-only
    [InlineData("hello", "hello")] // single word
    [InlineData("Hello World", "World Hello")] // standard usecase
    [InlineData("The quick brown fox", "fox brown quick The")]
    [InlineData(" hello world ", "world hello")] // trims spaces
    [InlineData("a b c", "c b a")] // multiple spaces
    public void ReverseWords_CommonCases(string input, string expected)
    {
        var actual = _stringService.ReverseWords(input);
        Assert.Equal(expected, actual);
    }
}
