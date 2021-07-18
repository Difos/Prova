using System.Threading.Tasks;
using ProjetoBRQ.Domain.Entities;

namespace ProjetoBRQ.Repository.Interfaces
{
    public interface IRepo
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
        Task<Pessoa[]> GetAllPessoas();
        Task<Pessoa> GetPessoaById(int id);
        
    }
}