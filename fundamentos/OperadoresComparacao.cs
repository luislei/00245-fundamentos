namespace Fundamentos01;

public class OperadoresComparacao
{
    public void Executar()
    {
        Console.WriteLine("== Operadores de Comparação ==");

        int x = 5;
        int y = 8;

        Console.WriteLine($" x = {x}, y = {y}");
        Console.WriteLine($" x == y ? {x==y} (igual a )");
        Console.WriteLine($" x != y ? {x!=y} (diferente )");
        Console.WriteLine($" x > y ? {x>y} (maior)");
        Console.WriteLine($" x < y ? {x<y} (menor)");
        Console.WriteLine($" x >= y ? {x>=y} (maior ou igual)");
        Console.WriteLine($" x <= y ? {x<=y} (menor ou igual)");


    }

}// fim da classe