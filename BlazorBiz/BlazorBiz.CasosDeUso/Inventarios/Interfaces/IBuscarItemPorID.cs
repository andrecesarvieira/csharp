using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios.Interfaces
{
    public interface IBuscarItemPorID
    {
        Task<Inventario> ExecutarAsync(int id);
    }
}