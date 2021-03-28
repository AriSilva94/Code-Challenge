using CodeChallenge.Models;
using CodeChallenge.Repository.Interfaces;
using CodeChallenge.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeChallenge.Service
{
    public class CargueiroService : ICargueiroService
    {
        private readonly ICargueiroRepository _cargueiroRepository;

        public CargueiroService(ICargueiroRepository cargueiroRepository)
        {
            _cargueiroRepository = cargueiroRepository;
        }

        public async Task Cadastrar(Cargueiro cargueiro)
        {
            if(cargueiro.Quantidade == null)
            {
                cargueiro.Quantidade = 0.0;
            }

            await _cargueiroRepository.CadastrarPeloBancodeDados(cargueiro);
        }

        public async Task<Cargueiro> ListarPorId(int id)
        {
            var cargueiro = await _cargueiroRepository.ListarPorIdBancodeDados(id);

            return cargueiro;
        }

        public async Task<List<Cargueiro>> ListarTodos()
        {
            var listarCargueiros = await _cargueiroRepository.ListarTodosBancodeDados();

            return listarCargueiros;
        }

        public async Task Atualizar(Cargueiro cargueiro)
        {
            await _cargueiroRepository.AtualizarPeloBancodeDados(cargueiro);
        }

        public async Task Remover(int id)
        {
            var cargueiro = await _cargueiroRepository.ListarPorIdBancodeDados(id);

            await _cargueiroRepository.RemoverPeloBancodeDados(cargueiro);
        }
    }
}
