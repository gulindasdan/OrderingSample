using OrderingSample.Business.Abstract;
using OrderingSample.DataAccess.Abstract;
using OrderingSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSample.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        readonly ICustomerRepository _customerRepository;
        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddAsync(Customer entity)
        {
            await _customerRepository.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Customer> entities)
        {
            await _customerRepository.AddRangeAsync(entities);
        }

        public async Task<Customer> Get(Expression<Func<Customer, bool>> predicate)
        {
            return await _customerRepository.Get(predicate);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> GetByIdAsync(string key)
        {
            return await _customerRepository.GetByIdAsync(key);
        }

        public async Task RemoveAsync(Customer entity)
        {
            await _customerRepository.RemoveAsync(entity);
        }

        public async Task RemoveRangeAsync(IEnumerable<Customer> entities)
        {
            await _customerRepository.RemoveRangeAsync(entities);
        }

        public async Task UpdateAsync(Customer entity)
        {
            await _customerRepository.UpdateAsync(entity);
        }
    }
}
