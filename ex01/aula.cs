using System;
using Accessibility;
using System.Collections.Generic;

internal class NewBaseType
{
    static void Main()
    {
       string nome = "daniel";
        char sexo = 'm';
        int idade = 10;
        Console.Write("ola sou" + nome + "idade" + idade);
        Console.Write("sexo" + sexo);
        somaNumero(15,12);
        List<string> a=new List<string>();
        a.Add("daniel");
        a.Add("julina");
        a.Add("carlos");
        a.Sort;
        foreach (String nome in a){
            Console.WriteLine(nome);
        }
        Console.WriteLine(a.Count);
        Console.WriteLine("ola");
    }
    static void somaNumero(int num1,int num2)
        {
            int aux =  num1 + num2;
            Console.WriteLine(" resultado da soma de numero "+num1+" numero "+num2+" é igual= "+aux);
        }
   

}

    