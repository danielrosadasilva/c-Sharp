using Newtonsoft.Json;
using QuickType;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

//https://quicktype.io/csharp    site para converter json em c#
internal class Program
{
    private static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        var response=await client.GetAsync("https://jsonplaceholder.typicode.com/users");       //site de teste de API
        var content=await response.Content.ReadAsStringAsync();
        var users = JsonConvert.DeserializeObject<User[]>(content);

        foreach(var item in users)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Email);
            Console.WriteLine(item.Address);
            Console.WriteLine(item.Company);
            Console.WriteLine("---------------------");
        }

    }
}

