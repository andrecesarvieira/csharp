using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharpPontoWeb.Models;
using SharpPontoWeb.Services;

namespace SharpPontoWeb.Pages
{
    public class IndexModel(RegistroService service) : PageModel
    {
        private readonly RegistroService _service = service;

    public IEnumerable<Registro> Registros { get; set; } = [];
    public int PaginaAtual { get; set; } = 1;
    public int TotalPaginas { get; set; }
    public int TamanhoPagina { get; set; } = 10;
    public bool HasNextPage => PaginaAtual < TotalPaginas && TotalPaginas > 0;

        public async Task OnGetAsync(int? pagina)
        {
            PaginaAtual = pagina ?? 1;
            var totalRegistros = await _service.ObterTotalRegistrosAsync();
            TotalPaginas = (int)Math.Ceiling(totalRegistros / (double)TamanhoPagina);
            Registros = await _service.ObterRegistrosPaginadosAsync(PaginaAtual, TamanhoPagina);
        }

        public async Task<IActionResult> OnPostRegistrarAsync()
        {
            await _service.RegistrarPontoAsync();
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostExcluirAsync(int id)
        {
            await _service.ExcluirRegistroAsync(id);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostInserirAsync(DateOnly Data, TimeOnly Entrada, TimeOnly Almoco, TimeOnly Retorno, TimeOnly Saida)
        {
            // Verifica se já existe registro para a data
            var existe = await _service.ObterRegistroDoDiaAsync(Data);
            if (existe != null)
            {
                ModelState.AddModelError(string.Empty, "Já existe registro para esta data.");
                await OnGetAsync(PaginaAtual);
                return Page();
            }

            var registro = new Registro
            {
                Data = Data,
                Entrada = Entrada,
                Almoco = Almoco,
                Retorno = Retorno,
                Saida = Saida
            };
            await _service.InserirPontoAsync(registro);
            return RedirectToPage();
        }
    }
}