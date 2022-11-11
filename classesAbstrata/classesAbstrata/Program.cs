// See https://aka.ms/new-console-template for more information
using classesAbstrata;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo v = new Veiculo();

          v.setId(1016);
        Console.WriteLine(v.getId());

        v.info();
    }
}