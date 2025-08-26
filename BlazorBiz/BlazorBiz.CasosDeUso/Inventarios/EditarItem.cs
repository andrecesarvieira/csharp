using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Inventarios.Interfaces;
using BlazorBiz.Entidades;

namespace BlazorBiz.CasosDeUso.Inventarios
{
    public class EditarItem : IEditarItem
    {
        private readonly IInventarioRepositorio item;

        public EditarItem(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task ExecutarAsync(Inventario item)
        {
            await this.item.AtualizarItemInventarioAsync(item);
        }
    }
}
