using BuyYours.Application.Contracts;
using BuyYours.Domain.Models;
using BuyYours.Persistence.Data;

namespace BuyYours.Infrastructure.Repositories
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
