using BuyYours.Application.Contracts;
using BuyYours.Domain.Models;
using BuyYours.Persistence.Data;

namespace BuyYours.Infrastructure.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}