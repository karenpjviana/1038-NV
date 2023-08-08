using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1038_AULA_03
{
    internal class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
        public double valorTotal { get; set; }

        public double ValorTotalEstoque()
        {
            return valorTotal = preco * quantidade;
        }

        public void AdicionarProdutos(int qtde) 
        {
            Console.WriteLine($"====== Estoque ======{Environment.NewLine}" +
                              $"Nome: {Environment.NewLine}{nome}" + 
                              $"Preço: {Environment.NewLine}{preco}" +
                              $"Quantidade: {Environment.NewLine}{quantidade + qtde}" +
                              $"Valor Total no estoque: {Environment.NewLine}{valorTotal}");
        }

        public void RemoverProdutos(int qtde)
        {
            Console.WriteLine($"====== Estoque ======{Environment.NewLine}" +
                              $"Nome: {Environment.NewLine}{nome}" +
                              $"Preço: {Environment.NewLine}{preco}" +
                              $"Quantidade: {Environment.NewLine}{quantidade - qtde}" +
                              $"Valor Total no estoque: {Environment.NewLine}{valorTotal}");
        }
    }
}