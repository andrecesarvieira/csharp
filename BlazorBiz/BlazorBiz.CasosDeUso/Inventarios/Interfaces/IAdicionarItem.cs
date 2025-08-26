using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios.Interfaces
{
    public interface IAdicionarItem
    {
        Task ExecutarAsync(Inventario item);
    }
}