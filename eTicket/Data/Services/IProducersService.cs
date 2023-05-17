using eTicket.Models;

namespace eTicket.Data.Services
{
    public interface IProducersService
    {
        Task<IEnumerable<Producer>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Producer producer);
        Task<Producer> Update(int id, Producer newProducer);
        Task DeleteAsync(int id);
    }
}
