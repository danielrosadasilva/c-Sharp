using ConsoleApp1;
using System;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
       // List<Pessoa> list = new List<Pessoa>();
      //  list.Add(new Pessoa());

        Pessoa pessoa = new Pessoa();
        
        List<string> nome= new List<string>();

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("digite um nome: ");
            string variavel;
            variavel=Console.ReadLine();   
            
            
            nome.Add(variavel);
            
            
          
        }
        nome.RemoveAt(0);
        Console.WriteLine("consulta de registros: ");
        foreach (string variavel in nome)
        {
            
            Console.WriteLine(variavel);
        }
        Console.WriteLine("confirme o nome a deletar: ");

        
        Console.WriteLine("qtd: "+nome.Count());
        // criarMenu(pessoa);

    }
    public static void verificar(int []array)
    {
        if (array.Length == 5)
        {
            Console.WriteLine("está cheio");
        }
        else
        {
            Console.WriteLine("não esta cheio");
        }
    }
    public static void criarMenu(Pessoa pessoa)
    {
        Console.WriteLine("1-cadastrar");
        Console.WriteLine("2-consutlar");
        Console.WriteLine("3-excluir");
        Console.WriteLine("4-atualizar");
        
        char escolha=char.Parse(Console.ReadLine());
        
        switch(escolha)
        {
            case '1':
                criarCadastro(pessoa);
                Console.Clear();
                criarMenu(pessoa);
         
                break;
            case '2':
                consultarCadastro(pessoa);
               
                criarMenu(pessoa);
                break;
            case '3':
               alterarCadastro(pessoa);
                Console.Clear();
                criarMenu(pessoa);

                break;
            case '4':
                break;
;
        }
    }
    public static void criarCadastro(Pessoa pessoa)
    {
        int contador = 0;
        string nome;
        string email;
        string endereco;
        Console.WriteLine("digite o nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("digite o email: ");
        email = Console.ReadLine();
        Console.WriteLine("digite o endereco: ");
        endereco =Console.ReadLine();
        pessoa.setNome(nome);
        pessoa.setEmail(email);
        pessoa.setEndereco(endereco);
        /*list.Add(new Pessoa());
           list[contador].setNome(nome);
           list[contador].setEmail(email);
           list[contador].setEndereco(endereco);
            contador++;*/
        
        

    }
    public static void consultarCadastro(Pessoa pessoa)
    {
            
            Console.WriteLine("Meu nome :{0} , email: {1}, endereco: {2}", pessoa.getNome(), pessoa.getEmail(), pessoa.getEndereco());
      
        
    }
    public static void alterarCadastro(Pessoa pessoa)
    {
        Console.WriteLine("falta implementar!!");
    }
    public static void arrayNumeros()
    {
        int[] numeros = new int[5];
        string[] names = new string[5];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Digite na posicao {0} o valor: ", i);
            numeros[i] = int.Parse(Console.ReadLine());
        }
        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine("Digite um nome na posicao {0} :", i);
            names[i] = Console.ReadLine();
        }
        foreach (string n in names) //foreach apenas para leitura de dados,não funciona pra gravar valores 
        {
            Console.WriteLine(n);
        }
        verificar(numeros);
    }
}