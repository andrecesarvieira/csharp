using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Inventarios.Interfaces;

namespace BlazorBiz.CasosDeUso.Inventarios
{
    public class ExcluirItem : IExcluirItem
    {
        private readonly IInventarioRepositorio item;

        public ExcluirItem(IInventarioRepositorio item)
        {
            this.item = item;
        }
        public async Task ExecutarAsync(int id)
        {
            await this.item.ExcluirItemInventarioAsync(id);
        }
    }
}
