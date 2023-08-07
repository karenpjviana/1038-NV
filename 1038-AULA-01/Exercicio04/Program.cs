using static System.Console;
namespace Exercicio04;
class Program
{
    static void Main(string[] args)
    {
        /*
         Escrever um programa que preencha um vetor de 100 elementos com valores inteiros aleatórios, e identifique o maior e o menor número gerados, e respectivas posições.
        */
        Random randNum = new Random();
        int[] vetor = new int[100];

        //Gerar números
        for (int i = 0; i < 100; i++)
            vetor[i] = randNum.Next(1000);

        int menor = vetor.Min();
        WriteLine("O menor número é: " + menor);
        
        int maior = vetor.Max();
        WriteLine("O menor número é: " + maior);

        ReadKey();
    }
}


