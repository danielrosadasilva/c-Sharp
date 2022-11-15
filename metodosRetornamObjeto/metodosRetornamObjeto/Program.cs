

using metodosRetornamObjeto;

internal class Program
{
    private static void Main(string[] args)
    {
        Galinha g1 = new Galinha("cocorico");
        Galinha g2 = new Galinha("joanazilda");
        g1.botar();
        g2.botar();
        g2.botar();
        g2.info();
    }
}