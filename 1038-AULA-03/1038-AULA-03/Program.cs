namespace _1038_AULA_03
{
    internal class Program
    { 
        enum Opcao { Adicionar = 1, Remover}
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de um produto em estoque(nome, preço e quantidade no estoque). 
                * Em seguida:
                * • Mostrar os dados do produto(nome, preço, quantidade no estoque, valor total no estoque)
                * • Realizar uma entrada no estoque e mostrar novamente os dados do produto
                * • Realizar uma saída no estoque e mostrar novamente os dados do produto.*/

            Produto produto = new();
            Console.WriteLine("====== Estoque ======");
            Console.WriteLine("Informe o nome do produto:");
            produto.nome = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto:");
            produto.preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o quantidade do produto no estoque:");
            produto.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"====== Estoque ======{Environment.NewLine}" +
                              $"Nome: {Environment.NewLine}{produto.nome}" +
                              $"Preço: {Environment.NewLine}{produto.preco}" +
                              $"Quantidade: {Environment.NewLine}{produto.quantidade}" +
                              $"Valor Total no estoque: {Environment.NewLine}{produto.valorTotal}");

            Console.WriteLine("Informe o quantidade do produto no estoque:");
            int opc = int.Parse(Console.ReadLine());
            Opcao opcao = (Opcao)opc;
            switch (opcao) {
                case Opcao.Adicionar:
                    Produto.AdicionarProdutos();

            }

        }
    }
}