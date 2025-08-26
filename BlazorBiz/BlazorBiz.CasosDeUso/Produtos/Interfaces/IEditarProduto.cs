using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Produtos.Interfaces
{
    public interface IEditarProduto
    {
        Task ExecutarAsync(Produto produto);
    }
}