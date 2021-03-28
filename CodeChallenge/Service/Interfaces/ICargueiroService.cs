using CodeChallenge.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeChallenge.Service.Interfaces
{
    public interface ICargueiroService
    {
        Task<List<Cargueiro>> ListarTodos();
        Task<Cargueiro> ListarPorId(int id);
        Task Cadastrar(Cargueiro cargueiro);
        Task Atualizar(Cargueiro cargueiro);
        Task Remover(int id);
    }
}
