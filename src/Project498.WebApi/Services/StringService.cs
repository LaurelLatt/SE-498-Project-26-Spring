namespace Project498.WebApi.Services;

public class StringService : IStringService
{
    public string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    
    public string ReverseWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        // Split on spaces, remove empty entries
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        // Reverse the array
        Array.Reverse(words);
        
        // Join back into a single string
        return string.Join(" ", words);
    }
}
