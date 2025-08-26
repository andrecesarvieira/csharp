using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios.Interfaces
{
    public interface IBuscarItemPorNome
    {
        Task<IEnumerable<Inventario>> ExecutarAsync(string nome = "");
    }
}