using BuyYours.Application.Contracts;
using BuyYours.Domain.Models;
using BuyYours.Persistence.Data;

namespace BuyYours.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
