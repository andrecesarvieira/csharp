using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Inventarios.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios
{
    public class AdicionarItem : IAdicionarItem
    {
        private readonly IInventarioRepositorio item;

        public AdicionarItem(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task ExecutarAsync(Inventario item)
        {
            await this.item.AdicionarItemInventarioAsync(item);
        }
    }
}
