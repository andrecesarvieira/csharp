using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos.Interfaces
{
    public interface IBuscarProdutoPorNome
    {
        Task<IEnumerable<Produto>> ExecutarAsync(string nome = "");
    }
}