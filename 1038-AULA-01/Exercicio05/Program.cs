internal class Program
{
    enum Opcao { Alcool = 1, Gasolina, Diesel, Fim };
    private static void Main(string[] args)
    {
        /*
        Um Posto de combustiveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustivel abastecido (codificado da seguinte forma: 1.Álcool 
                                                                                   2.Gasolina                                                                                        3.Diesel 
                                                                                   4.Fim). 
        Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). 
        O programa será encerrado quando o código informado for o número 4. 
        Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustivel, conforme exemplo.
        */
        int alcool = 0;
        int gasolina = 0;
        int diesel = 0;
        bool escolheuSair = false;
        while (escolheuSair == false)
        {
            Console.WriteLine("Escolha uma opção:");

            Console.WriteLine($"1 - Álcool{Environment.NewLine}"
                            + $"2 - Gasolina{Environment.NewLine}"
                            + $"3 - Diesel{Environment.NewLine}"
                            + $"4 - Fim");
            try
            {
                int opcao = int.Parse(Console.ReadLine());

                Opcao escolha = (Opcao)opcao;
                switch (escolha)
                {
                    case Opcao.Alcool:
                        alcool++;
                        break;
                    case Opcao.Gasolina:
                        gasolina++;
                        break;
                    case Opcao.Diesel:
                        diesel++;
                        break;
                    case Opcao.Fim:
                        escolheuSair = true;
                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Valor inválido");
                Thread.Sleep(1000);
            }
        }

        Console.WriteLine($"MUITO OBRIGADO{Environment.NewLine}" +
                          $"Alcool: {alcool}{Environment.NewLine}" +
                          $"Gasolina: {gasolina}{Environment.NewLine}" +
                          $"Diesel: {diesel}{Environment.NewLine}");
        Console.ReadKey();

    }
}