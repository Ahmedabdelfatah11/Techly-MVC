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
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(OrderDetail category)
        {
            _db.OrderDetails.Update(category);
        }
    }
}
