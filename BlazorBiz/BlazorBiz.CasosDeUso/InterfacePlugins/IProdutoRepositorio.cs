using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.InterfacePlugins
{
    public interface IProdutoRepositorio
    {
        Task AdicionarProdutoAsync(Produto produto);
        Task AtualizarProdutoAsync(Produto produto);
        Task ExcluirProdutoAsync(int id);
        Task<Produto> BuscarProdutoPorIdAsync(int id);
        Task<IEnumerable<Produto>> BuscarProdutoPorNomeAsync(string nome);
    }
}