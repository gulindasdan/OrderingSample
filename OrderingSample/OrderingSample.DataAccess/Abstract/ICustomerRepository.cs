using OrderingSample.Core.DataAccess;
using OrderingSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSample.DataAccess.Abstract
{
    public interface ICustomerRepository : IRepository<Customer,string>
    {
    }
}
