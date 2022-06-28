namespace Alura.Loja.Testes.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            var produto = new Produto
            {
                Nome = "pão francês",
                PrecoUnitario = 0.4,
                Unidade = "unidade",
                Categoria = "Padaria"
            };

            var compra = new Compra
            {
                Quantidade = 6,
                Produto = produto,
                Preco = produto.PrecoUnitario * 6
            };

            using (var repo = new LojaContext())
            {
                repo.Compras.Add(compra);
                repo.SaveChanges();
            }
        }
    }
}