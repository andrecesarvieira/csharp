using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Produtos.Interfaces;

namespace BlazorBiz.CasosDeUso.Produtos
{
    public class ExcluirProduto : IExcluirProduto
    {
        private readonly IProdutoRepositorio produto;

        public ExcluirProduto(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task ExecutarAsync(int id)
        {
            await this.produto.ExcluirProdutoAsync(id);
        }
    }
}
