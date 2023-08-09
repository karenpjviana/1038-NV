namespace _1038_AULA_03
{
    internal class Program
    {
        enum Opcao { Adicionar = 1, Remover, Sair }
        static void Main(string[] args)
        {
            /* Fazer um programa para ler os dados de um produto em estoque(nome, preço e quantidade no estoque). 
                * Em seguida:
                * • Mostrar os dados do produto(nome, preço, quantidade no estoque, valor total no estoque)
                * • Realizar uma entrada no estoque e mostrar novamente os dados do produto
                * • Realizar uma saída no estoque e mostrar novamente os dados do produto.*/

            bool sair = false;
            Produto produto = new();

            try
            {
                Inicio(produto);
                Listagem(produto);

                while (!sair)
                {
                    Console.WriteLine($"Escolha uma opção:\n" +
                                        $"1 - Adicionar\n" +
                                        $"2 - Remover\n" +
                                        $"3 - Sair");
                    int opc = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Opcao opcao = (Opcao)opc;
                    switch (opcao)
                    {
                        case Opcao.Adicionar:
                            Adicionar(produto);
                            break;
                        case Opcao.Remover:
                            Remover(produto);
                            break;
                        case Opcao.Sair:
                            sair = true;
                            break;

                    }
                    Console.Clear();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Algo deu errado ao esolher a opção. Por Favor, tente novamente.");
                Console.Clear();
            }

        }

        public static void Inicio(Produto produto)
        {
            Console.WriteLine("====== Estoque ======");
            Console.WriteLine("Informe o nome do produto:");
            produto.nome = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto:");
            produto.preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quantidade do produto no estoque:");
            produto.quantidade = int.Parse(Console.ReadLine());

            produto.ValorTotalEstoque();
        }

        public static void Listagem(Produto produto)
        {
            Console.Clear();
            Console.WriteLine($"====== Estoque ======{Environment.NewLine}" +
                              $"Nome: {produto.nome}{Environment.NewLine}" +
                              $"Preço: R${produto.preco.ToString("F2")}{Environment.NewLine}" +
                              $"Quantidade: {produto.quantidade}{Environment.NewLine}" +
                              $"Valor Total no estoque: R${produto.valorTotal.ToString("F2")}{Environment.NewLine}");
        }

        public static void Adicionar(Produto produto)
        {
            Console.WriteLine($"====== Adicionar produtos ======{Environment.NewLine}" +
                              $"Informe a quantidade de produtos que deseja adicionar:");
            int qtde = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtde);

            Listagem(produto);
            Console.ReadKey();
        }

        public static void Remover(Produto produto)
        {
            bool parar = false;

            while (parar == false)
            {


                Console.WriteLine($"====== Remover produtos ======{Environment.NewLine}" +
                                  $"Informe a quantidade de produtos que deseja remover:");


                int qtde = int.Parse(Console.ReadLine());

                if (qtde <= produto.quantidade)
                {
                    produto.RemoverProdutos(qtde);
                    parar = true;
                }
                else if (produto.quantidade <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Quantidade de produtos removidos não pode ser maior que a quantidade em estoque. Tente novamente.");
                    Console.ReadKey();
                    parar = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Quantidade de produtos removidos não pode ser maior que a quantidade em estoque. Tente novamente.");
                    qtde = 0;
                    Console.ReadKey();
                }
            }

            Listagem(produto);
            Console.ReadKey();


        }
    }
}