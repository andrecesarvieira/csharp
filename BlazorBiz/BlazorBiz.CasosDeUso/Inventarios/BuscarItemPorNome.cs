using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Inventarios.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios
{
    public class BuscarItemPorNome : IBuscarItemPorNome
    {
        private readonly IInventarioRepositorio item;

        public BuscarItemPorNome(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task<IEnumerable<Inventario>> ExecutarAsync(string nome = "")
        {
            return await item.BuscarItemPorNomeAsync(nome);
        }
    }
}
