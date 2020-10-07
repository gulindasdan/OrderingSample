using OrderingSample.Core.Entity.EntityFramework;
using OrderingSample.DataAccess.Abstract;
using OrderingSample.DataAccess.Context;
using OrderingSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSample.DataAccess.Concrete
{
    public class OrderRepository : EfRepositoryBase<Order, string, OrderDbContext>, IOrderRepository
    {
        public OrderRepository(OrderDbContext context) : base(context)
        {
        }
    }
}
