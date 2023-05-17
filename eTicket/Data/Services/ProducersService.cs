using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ProducersService : IProducersService
    {

        private readonly AppDbContext _context;
        public ProducersService(AppDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Producer producer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producer>> GetAllAsync()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        }

        public Task<Actor> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Producer> Update(int id, Producer newProducer)
        {
            throw new NotImplementedException();
        }
    }
}
