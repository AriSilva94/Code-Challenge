using CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Repository.Interfaces
{
    public interface ICargueiroRepository
    {
        Task<List<Cargueiro>> ListarTodosBancodeDados();

        Task<Cargueiro> ListarPorIdBancodeDados(int id);

        Task CadastrarPeloBancodeDados(Cargueiro cargueiro);

        Task AtualizarPeloBancodeDados(Cargueiro cargueiro);
        Task RemoverPeloBancodeDados(Cargueiro cargueiro);
    }
}
