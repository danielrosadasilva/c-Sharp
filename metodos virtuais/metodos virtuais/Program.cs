using metodos_virtuais;

internal class Program
{
    private static void Main(string[] args)
    {
        Base b = new Base();
        Primeira p=new Primeira();
        Segunda s= new Segunda();
        b.info();
        p.info();
        s.info();

        /*Com metodos virtuais é possivel na herança
         usar a mesma assinatura do metodo .*/
    }
}