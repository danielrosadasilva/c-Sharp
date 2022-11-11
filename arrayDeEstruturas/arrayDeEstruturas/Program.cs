

using arrayDeEstruturas;

internal class Program
{
     static void Main(string[] args)
    {
        Carro[] carros = new Carro[4];
        carros[0].setCor("preto");
        carros[0].setModelo("gol");
        carros[1].setCor("azul");
        carros[1].setModelo("chevete");
        carros[2].setCor("verde");
        carros[2].setModelo("palio");
        carros[3].setCor("roxo");
        carros[3].setModelo("camaro");
       


        for(int i=0; i < carros.Length; i++)
        {
            carros[i].info();
        }
    }
}