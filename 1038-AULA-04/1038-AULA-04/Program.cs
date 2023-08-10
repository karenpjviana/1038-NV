namespace _1038_AULA_04;
class Program
{
    enum Opcao { Soma = 1, Subtracao, Multiplicacao, Divisao, Sair }
    static void Main(string[] args)
    {
        /*
         * Crie uma classe Calculadora com dois atributos, valor1 e valor2.
         * Crie 4 métodos de operação básica matemática desses dois valores. 
         * Crie uma classe de teste com um menu para a pessoa selecionar qual operação deseja realizar.
         * Mostre o resultado na tela e pergunte se deseja realizar novo calculo.
         * Utilize o máximo do conteúdo aprendido até aqui.
         */

        bool sair = false;
        Calculadora calculadora = new();

        try
        {
            while (!sair)
            {
                Console.WriteLine($" === Calculadora ===");
                InformaValores(calculadora);

                Console.WriteLine($"Escolha uma opção:\n" +
                                    $"1 - Soma\n" +
                                    $"2 - Subtração\n" +
                                    $"3 - Multiplicação\n" +
                                    $"4 - Divisão\n" +
                                    $"5 - Sair");
                int opc = int.Parse(Console.ReadLine());
                Console.Clear();

                Opcao opcao = (Opcao)opc;
                switch (opcao)
                {
                    case Opcao.Soma:
                        SomarValores(calculadora);
                        break;
                    case Opcao.Subtracao:
                        SubtrairValores(calculadora);
                        break;
                    case Opcao.Multiplicacao:
                        MultiplicarValores(calculadora);
                        break;
                    case Opcao.Divisao:
                        DividirValores(calculadora);
                        break;
                    case Opcao.Sair:
                        sair = true;
                        break;

                }
                Console.Clear();
                sair = NovoCalculo();
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Algo deu errado ao esolher a opção. Por Favor, tente novamente.");
            Console.Clear();
        }


    }

    public static void InformaValores(Calculadora calculadora)
    {
        Console.WriteLine("Informe o valor 1:");
        calculadora.valor1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor 2:");
        calculadora.valor2 = double.Parse(Console.ReadLine());
        Console.Clear();
    }

    public static void SomarValores(Calculadora calculadora)
    {
        Console.WriteLine("A soma dos valores é: " + calculadora.Soma());
        Console.ReadKey();
    }

    public static void SubtrairValores(Calculadora calculadora)
    {
        Console.WriteLine("A subtração dos valores é: " + calculadora.Subtração());
        Console.ReadKey();
    }

    public static void DividirValores(Calculadora calculadora)
    {
        Console.WriteLine("A subtração dos valores é: " + calculadora.Divisão());
        Console.ReadKey();
    }

    public static void MultiplicarValores(Calculadora calculadora)
    {
        Console.WriteLine("A subtração dos valores é: " + calculadora.Multiplicação());
        Console.ReadKey();
    }

    public static bool NovoCalculo()
    {
        Console.WriteLine("Deseja fazer um novo cálculo: 1 - Sim, 2 - Não");
        bool sair = int.Parse(Console.ReadLine()) == 1 ? false : true;
        Console.Clear();
        return sair;
    }
}


