using CodeChallenge.Models;
using CodeChallenge.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodeChallenge.Controllers
{
    public class CargueiroController : Controller
    {
        private readonly ICargueiroService _cargueiroService;

        public CargueiroController(ICargueiroService configureService)
        {
            _cargueiroService = configureService;
        }
        public async Task<IActionResult> Index()
        {
            var listarCargueiros = await _cargueiroService.ListarTodos();

            return View(listarCargueiros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tipo,Retorno,Saida,Quantidade,TipoMinerio")] Cargueiro cargueiro)
        {
            if (ModelState.IsValid)
            {
                await _cargueiroService.Cadastrar(cargueiro);

                return RedirectToAction(nameof(Index));

            }
            return View(cargueiro);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var cargueiro = await _cargueiroService.ListarPorId((int)id);

                return View(cargueiro);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tipo,Retorno,Saida,Quantidade,TipoMinerio")] Cargueiro cargueiro)
        {
            if (id != cargueiro.Id)
            {
                return NotFound();
            }

            await _cargueiroService.Atualizar(cargueiro);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                var cargueiro = await _cargueiroService.ListarPorId((int)id);

                return View(cargueiro);
            }

            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _cargueiroService.Remover(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
