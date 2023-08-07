namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            - Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 
            */
            int _in = 0;
            int _out = 0;

            try
            {
                Console.WriteLine("Escreva um número inteiro:");
                int num = int.Parse(Console.ReadLine());

                int[] valores = new int[num];

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Escreva outro número inteiro:");
                    valores[i] = int.Parse(Console.ReadLine());
                }

                foreach (int val in valores)
                {
                    if (val >= 10 && val <= 20)
                        _in++;
                    else
                        _out++;
                }

                Console.WriteLine(_in + " in");
                Console.WriteLine(_out + " out");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo deu errado. Tente novamente!");
            }
            
        }
    }
}