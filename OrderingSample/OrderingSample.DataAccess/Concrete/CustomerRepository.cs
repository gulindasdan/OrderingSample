using OrderingSample.Core.Entity.EntityFramework;
using OrderingSample.DataAccess.Abstract;
using OrderingSample.DataAccess.Context;
using OrderingSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSample.DataAccess.Concrete
{
    public class CustomerRepository : EfRepositoryBase<Customer, string, OrderDbContext>, ICustomerRepository
    {
        public CustomerRepository(OrderDbContext context) : base(context)
        {
        }
    }
}
