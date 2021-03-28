using CodeChallenge.Data;
using CodeChallenge.Models;
using CodeChallenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Repository
{
    public class CargueiroRepository : ICargueiroRepository
    {
        private readonly CadastroCargueiroContext _context;

        public CargueiroRepository(CadastroCargueiroContext context)
        {
            _context = context;
        }

        public async Task CadastrarPeloBancodeDados(Cargueiro cargueiro)
        {
            _context.Add(cargueiro);

            await _context.SaveChangesAsync();
        }

        public async Task<Cargueiro> ListarPorIdBancodeDados(int id)
        {
            return await _context.Cargueiros.SingleOrDefaultAsync(p => p.Id.Equals(id));
        }

        public async Task<List<Cargueiro>> ListarTodosBancodeDados()
        {
            return await _context.Cargueiros.ToListAsync();
        }

        public async Task AtualizarPeloBancodeDados(Cargueiro cargueiro)
        {
            _context.Cargueiros.Update(cargueiro);
            await _context.SaveChangesAsync();
        }

        public async Task RemoverPeloBancodeDados(Cargueiro cargueiro)
        {
            _context.Cargueiros.Remove(cargueiro);
            await _context.SaveChangesAsync();
        }
    }
}
