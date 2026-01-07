//HttpClient Docs: https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-10.0
//Provides a class for sending HTTP requests and receiving HTTP responses from a resource identified by a URI.
public class HttpClientClass
{
    // HttpClient is intended to be instantiated once per application, rather than per-use.
    static readonly HttpClient client = new HttpClient();

    public static async Task<string> OdinGraphQLEndpoint()
    {
        //Docs: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-catch-statement
        try
        {
            string reponseBody = await client.GetStringAsync("https://odin.graphql.endpoint/api");
            Console.WriteLine(reponseBody);
            return reponseBody;
        } 
        catch (HttpRequestException exception)
        {
            return $"Request error: {exception.Message}";
        }
        
    }
}
