using static System.Console;
namespace Exercicio01;
class Program
{
    static void Main(string[] args)
    {
        /*
        Um imposto é calculado com base na seguinte tabela: Até  1.200,00 isento
                                                                de 1.201,00 a 2.500,00 10%
                                                                de 2.501,00 a 5.000,00 15%
                                                                acima de 5.000,00 20%.
        Implemente um programa que leia o valor base e calcule o imposto a pagar.
        */
        try
        {
            WriteLine($"==== Cálculo do imposto a pagar ===={Environment.NewLine}" +
                  $"Informe o valor base:");
            decimal valorBase = decimal.Parse(ReadLine());
            ImpostoAPagar(valorBase);
            ReadKey();
        }
        catch (Exception)
        {
            WriteLine("Algo deu errado. Por favor, tente novamente.");
            ReadKey();
        }
    }

    public static void ImpostoAPagar(decimal valorBase)
    {
        decimal imposto;

        if (valorBase <= 1200)
        {
            WriteLine("Isento de imposto!");
        }
        else if (valorBase > 1200 && valorBase <= 2500)
        {
            imposto = 0.1M * valorBase;
            WriteLine("Valor do imposto a pagar: R$ " + imposto.ToString("F2"));
        }
        else if (valorBase > 2500 && valorBase <= 5000)
        {
            imposto = 0.15M * valorBase;
            WriteLine("Valor do imposto a pagar: R$ " + imposto.ToString("F2"));
        }
        else
        {
            imposto = 0.2M * valorBase;
            WriteLine("Valor do imposto a pagar: R$ " + imposto.ToString("F2"));
        }
    }
}

