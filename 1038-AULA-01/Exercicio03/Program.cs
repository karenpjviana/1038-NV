using static System.Console;
namespace Exercicio03;
class Program
{
    static void Main(string[] args)
    {
        /*
         Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e quantidade mínima em estoque de um produto. Calcular e escrever a quantidade média ((quantidade média = quantidade máxima + quantidade mínima)/2). Se a quantidade em estoque for maior ou igual a quantidade média escrever a mensagem 'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'.
        */

        try
        {
            WriteLine($"==== Estoque ===={Environment.NewLine}" +
                  $"Informe a quantidade atual em estoque:");
            int qtdeEstoque = int.Parse(ReadLine());
            WriteLine("Informe a quantidade máxima do estoque:");
            int qtdeMax = int.Parse(ReadLine());
            WriteLine("Informe a quantidade mínima do estoque:");
            int qtdeMin = int.Parse(ReadLine());
            Console.Clear();
            QuantidadeMedia(qtdeEstoque, qtdeMax, qtdeMin);
            ReadKey();
        }
        catch (Exception)
        {
            WriteLine("Algo deu errado. Por favor, tente novamente.");
            ReadKey();
        }
    }

    public static void QuantidadeMedia(int qtdeEstoque, int qtdeMax, int qtdeMin)
    {
        double qtdeMed = (qtdeMax + qtdeMin) / 2;

        if (qtdeEstoque >= qtdeMed)
            WriteLine("Não efetuar compra.");
        else
            WriteLine("Efetuar compra.");
    }
}

