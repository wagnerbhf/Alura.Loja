namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public int CompraId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}