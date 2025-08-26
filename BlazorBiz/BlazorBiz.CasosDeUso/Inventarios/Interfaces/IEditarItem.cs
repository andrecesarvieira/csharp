using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios.Interfaces
{
    public interface IEditarItem
    {
        Task ExecutarAsync(Inventario item);
    }
}