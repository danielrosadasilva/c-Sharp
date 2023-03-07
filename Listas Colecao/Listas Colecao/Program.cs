
internal class Program
{
    public static void tornarMaiusculo(List <string> carros) //tornando toda a lista maiusculae ordenada
    {       
        for (int i = 0; i <=carros.Count; i++)
        {
           
            try
            {
                string[] aux = new string[carros.Count];
                aux[i] = carros[i].ToUpper();
                Console.WriteLine(aux[i]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
    public static void consultarinfo(List<string> carros,string nome) //tratamento de pesquisa com maiuscula e minuscula na lista.
    {
        if (carros.Contains(nome.ToUpper()))
        {
            Console.WriteLine("contem maiuscula");
            if (carros.Contains(nome.ToLower()))
            {
                Console.WriteLine("Contem minuscula");
            }
        }
        else
        {
            Console.WriteLine("não contem :{0}", nome);
        }       
    }
    private static void Main(string[] args)
    {
        List<string> carros = new List<string>();
        carros.Add("corola");
        carros.Add("FIAT");
        carros.Add("chevette");
        carros.Add("HILUX");
        //int tamanho=carros.Count;
        //carros.Sort();
        Console.WriteLine("digite um nome de carro para adicionar a lista:");
        carros.Add(Console.ReadLine());
        Console.WriteLine("Digite um nome de carro para pesquisar na lista!!");
        string nome=Console.ReadLine();
        Console.WriteLine("-------LISTA--------");
        foreach (string c in carros)
        {
            Console.WriteLine("carro: {0}", c);
        }
        Console.WriteLine("------RESULTADO------");
        consultarinfo(carros,nome);
        Console.WriteLine("---------------------");
        tornarMaiusculo(carros);
        carros.Sort();
        foreach(string c in carros)
        {
            Console.WriteLine("nova lista: " + c);
        }    
    }
}