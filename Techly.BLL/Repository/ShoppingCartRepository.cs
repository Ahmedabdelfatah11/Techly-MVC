using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Techly.BLL.Interfaces;
using Techly.DAL.Context;
using Techly.DAL.Models;

namespace Techly.BLL.Repository
{
    public class ShoppingCartRepository :Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(ShoppingCart shoppingCart)
        {
            _db.ShoppingCarts.Update(shoppingCart);
        }
    }
}
