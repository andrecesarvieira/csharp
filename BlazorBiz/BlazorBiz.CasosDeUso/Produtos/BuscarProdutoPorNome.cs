using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Produtos.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos
{
    public class BuscarProdutoPorNome : IBuscarProdutoPorNome
    {
        private readonly IProdutoRepositorio produto;

        public BuscarProdutoPorNome(IProdutoRepositorio produto)
        {
            this.produto = produto;
        }
        public async Task<IEnumerable<Produto>> ExecutarAsync(string nome = "")
        {
            return await produto.BuscarProdutoPorNomeAsync(nome);
        }
    }
}
