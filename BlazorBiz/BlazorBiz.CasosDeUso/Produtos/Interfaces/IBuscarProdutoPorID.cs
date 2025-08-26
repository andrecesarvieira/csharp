using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos.Interfaces
{
    public interface IBuscarProdutoPorID
    {
        Task<Produto> ExecutarAsync(int id);
    }
}