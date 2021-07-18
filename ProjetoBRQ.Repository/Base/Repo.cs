using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoBRQ.Domain.Entities;
using ProjetoBRQ.Repository.Infra;
using ProjetoBRQ.Repository.Interfaces;

namespace ProjetoBRQ.Repository.Base
{
    public class Repo : IRepo
    {
        public readonly PessoaContext _context;
        public Repo(PessoaContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Pessoa[]> GetAllPessoas()
        {
            IQueryable<Pessoa> query = _context.Pessoas;
            
            query =  query.AsNoTracking().OrderBy(p => p.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Pessoa> GetPessoaById(int id)
        {
            IQueryable<Pessoa> query = _context.Pessoas;

            query = query.AsNoTracking().OrderBy(p  => p.Id);

            return await query.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}