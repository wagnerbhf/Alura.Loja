﻿using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double PrecoUnitario { get; set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> PromocoesProdutos { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome} - {Categoria} - {PrecoUnitario}";
        }
    }
}