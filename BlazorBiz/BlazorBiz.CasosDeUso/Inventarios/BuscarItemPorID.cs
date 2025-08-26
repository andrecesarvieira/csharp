using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Inventarios.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios
{
    public class BuscarItemPorID : IBuscarItemPorID
    {
        private readonly IInventarioRepositorio item;

        public BuscarItemPorID(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task<Inventario> ExecutarAsync(int id)
        {
            return await item.BuscarItemPorIdAsync(id);
        }
    }
}
