namespace Fundamentos01;

public class OperadoresLogicos
{
    
public void Executar()
    {
        Console.WriteLine("Operadores Logicos");

        bool temIdade = true;
        bool temCarta = false;

        Console.WriteLine($"Tem idade ? {temIdade}");
        Console.WriteLine($"Tem carta ? {temCarta}");

        Console.WriteLine();
        Console.WriteLine($"Pode conduzir ? (tem idade e carta) -> {temIdade && temCarta} (and)" );
        Console.WriteLine($"Pode tentar conduzir ? (tem idade ou carta) -> {temIdade || temCarta} (or)" );
        Console.WriteLine($"Não tem idade ? (!tem idade) -> {!temIdade} (not)" );


    }


}// fim da class