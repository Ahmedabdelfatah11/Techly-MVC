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
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Update(OrderHeader category)
        {
            _db.OrderHeaders.Update(category);
        }
    }
}
