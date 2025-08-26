using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Produtos.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos
{
    public class EditarProduto : IEditarProduto
    {
        private readonly IProdutoRepositorio produto;

        public EditarProduto(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task ExecutarAsync(Produto produto)
        {
            await this.produto.AtualizarProdutoAsync(produto);
        }
    }
}
