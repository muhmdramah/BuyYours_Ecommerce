using BuyYours.Application.Contracts;
using BuyYours.Domain.Models;
using BuyYours.Persistence.Data;

namespace BuyYours.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
