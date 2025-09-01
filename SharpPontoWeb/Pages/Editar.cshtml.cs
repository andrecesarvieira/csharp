using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharpPontoWeb.Models;
using SharpPontoWeb.Services;

namespace SharpPontoWeb.Pages
{
    public class EditarModel(RegistroService service) : PageModel
    {
        private readonly RegistroService _service = service;

        [BindProperty]
        public Registro Registro { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var registro = await _service.ObterRegistroPorIdAsync(id);
            if (registro == null)
                return RedirectToPage("Index");
            Registro = registro;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AtualizarRegistroAsync(Registro);
            return RedirectToPage("Index");
        }
    }
}