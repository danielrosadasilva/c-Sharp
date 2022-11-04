// See https://aka.ms/new-console-template for more information

using indexadorClasse;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro c = new Carro();
        Moto m = new Moto();
        c[2] = 200;
        Console.WriteLine("velocidade" + c[2]);
        c[2] = 100;
        Console.WriteLine(c[2]);
        c.criarCarro(2022, "hde4554", "gol", "azul");
        m.criarMoto(2006, "hxb4265", "fan", "preta");

        m.acelerar();
        m.freiar();
        c.atirar();
        c.acelerar();
        c.infoCarro();
        c.dano();
        c.dano();
        c.acelerar();
        c.infoCarro();

    }
}