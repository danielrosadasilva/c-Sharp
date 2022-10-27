using ConsoleApp1;
using System;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[5];
        string[] names = new string[5];
        for(int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Digite na posicao {0} o valor: ", i);
            numeros[i] = int.Parse(Console.ReadLine());
        }
        foreach (int i in numeros)
        {
            Console.WriteLine(i);
        }
        for (int i=0; i < names.Length; i++)
        {
            Console.WriteLine("Digite um nome na posicao {0} :",i);
            names[i]=Console.ReadLine();
        }
        foreach(string n in names) //foreach apenas para leitura de dados,não funciona pra gravar valores 
        {
            Console.WriteLine(n);
        }
        verificar(numeros);
       
     
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
    
}