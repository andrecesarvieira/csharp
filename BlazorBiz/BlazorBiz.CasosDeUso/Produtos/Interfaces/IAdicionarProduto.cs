using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos.Interfaces
{
    public interface IAdicionarProduto
    {
        Task ExecutarAsync(Produto produto);
    }
}