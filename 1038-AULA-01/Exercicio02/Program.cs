using static System.Console;
namespace Exercicio02;
class Program
{
    static void Main(string[] args)
    {
        /*
       A jornada de trabalho semanal de um funcionário é de 40 horas. O funcionário que trabalhar mais de 40 horas receberá hora extra cujo cálculo é o valor da hora regular com um acréscimo de 50%.
       Escreva um algoritmo que leia o número de horas trabalhadas em um mês, o salário por hora e escreva o salário total do funcionário, que deverá ser acrescido das horas extras, caso tenham sido trabalhadas (considere que o mês possua 4 semanas exatas).
       */

        double horasTrabalhadas;
        double salarioHora;
     
        try
        {
            WriteLine($"==== Horas extras ===={Environment.NewLine}" +
                  $"Informe o número de horas trabalhadas nesse mês:");
            horasTrabalhadas = double.Parse(ReadLine());
            WriteLine("Informe o salário por hora:");
            salarioHora = double.Parse(ReadLine());
            SalarioTotal(horasTrabalhadas, salarioHora);
            ReadKey();
        }
        catch (Exception)
        {
            WriteLine("Algo deu errado. Por favor, tente novamente.");
            ReadKey();
        }
    }

    public static void SalarioTotal(double horasTrabalhadas, double salarioHora)
    {
        double salarioTotal;
        double horaExtra;

        if (horasTrabalhadas >= 0 && horasTrabalhadas <= 160)
        {
            WriteLine("Você não fez hora extra. Seu salário é: R$" + (horasTrabalhadas * salarioHora).ToString("F2"));
            ReadKey();
        }
        else if (horasTrabalhadas > 160)
        {
            horaExtra = horasTrabalhadas - 160;
            salarioTotal = 160 * salarioHora + horaExtra * salarioHora * 1.5;
            WriteLine($"Você fez {horaExtra} horas de hora extra. Seu salário é: R${salarioTotal.ToString("F2")}");
            ReadKey();
        }
        else
        {
            WriteLine("Algo deu errado. Por favor, tente novamente.");
            ReadKey();
        }
    }
}

