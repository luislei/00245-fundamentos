namespace Fundamentos01;

public class VariaveisETiposDeDados
{
    string sobreNome = "Lei";
   public void Executar()
    {
        
        Console.WriteLine("📦 VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("Variáveis são espaços na memória para guardar informações.");
        Console.WriteLine();


        int idade = 25;
        double altura = 1.75;
        float media = 1950;
        char letra = 'A';
        string nome = "Luis";
        string nomeComposto = nome + "Lei"; // Concatenação
        bool estudante = true;

        Console.WriteLine($"int -> idade : {idade} (numeros inteiros)");
        Console.WriteLine($"double -> altura : {altura} (numeros decimais)");
        Console.WriteLine($"char -> letra : {letra} (um unico carater)");
        Console.WriteLine($"string -> nome : {nome} (texto)");
        Console.WriteLine($"variavel global -> sobreNome : {this.sobreNome} (variavel global)");
        Console.WriteLine($"bool -> estudante : {estudante} (booleano ou seja V ou F)");



    } 


}// fim da classe