using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Produtos.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos
{
    public class AdicionarProduto : IAdicionarProduto
    {
        private readonly IProdutoRepositorio produto;

        public AdicionarProduto(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task ExecutarAsync(Produto produto)
        {
            await this.produto.AdicionarProdutoAsync(produto);
        }
    }
}
