
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> carros = new Dictionary<int, string>();
        carros.Add(1, "corola");
        carros.Add(2, "fiat");
        carros.Add(45, "mustang");
        carros.Add(20, "ferrari");
        
      
       
        verificarKey(carros,2);
        exibirDictionary(carros);
    }

    public static void verificarKey(Dictionary<int,string> carros,int key)
    {
        if (carros.ContainsKey (key))
        {
            Console.WriteLine("contem sim a key:{0}",key);
        }
        else
        {
            Console.WriteLine("não contém!!");
        }
    }
    public static void verificarValue(Dictionary<int,string> carros, string value)
    {
        if (carros.ContainsValue(value))
        {
            Console.WriteLine("contem o value: {0}",carros.Values);
        }
    }
    public static void exibirDictionary(Dictionary<int,string> carros)
    {
        foreach (KeyValuePair<int, string> v in carros)
        {
            Console.WriteLine("chave: {0} valor:{1}", v.Key, v.Value);
        }
        Console.WriteLine("------segunda maneira------");
        foreach (string v in carros.Values) // outra maneira de fazer,um pouco mais simples!!
        {
            Console.WriteLine(v);
        }
    }
}