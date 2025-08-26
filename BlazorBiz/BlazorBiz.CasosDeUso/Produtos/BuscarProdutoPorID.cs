using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Produtos.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos
{
    public class BuscarProdutoPorID : IBuscarProdutoPorID
    {
        private readonly IProdutoRepositorio produto;

        public BuscarProdutoPorID(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task<Produto> ExecutarAsync(int id)
        {
            return await produto.BuscarProdutoPorIdAsync(id);
        }
    }
}
