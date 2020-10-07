using OrderingSample.Core.Business;
using OrderingSample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSample.Business.Abstract
{
    public interface ICustomerService : IService<Customer, string>
    {
    }
}
