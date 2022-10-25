using System;
class principal{
    
    static void Main(string[] args){
        string nome= "daniel";
        char sexo='m';
        int idade=10;
        Console.Write("ola sou"+nome+"idade"+idade);
        Console.Write("sexo"+sexo);
        somanumero(10,15);
        console.readline();
        
    }

    static void somanumero(int num1,int num2){
        int aux = num1 + num2;
        Console.Writeline("resultado da soma de numero"+num1)+"numero"+num2+"é igual="+aux;
    }
}