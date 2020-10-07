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
    public class OrderManager : IOrderService
    {
        readonly IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task AddAsync(Order entity)
        {
            await _orderRepository.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<Order> entities)
        {
            await _orderRepository.AddRangeAsync(entities);
        }

        public async Task<Order> Get(Expression<Func<Order, bool>> predicate)
        {
            return await _orderRepository.Get(predicate);
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _orderRepository.GetAllAsync(); 
        }

        public async Task<Order> GetByIdAsync(string key)
        {
            return await _orderRepository.GetByIdAsync(key);
        }

        public async Task RemoveAsync(Order entity)
        {
            await _orderRepository.RemoveAsync(entity);
        }

        public async Task RemoveRangeAsync(IEnumerable<Order> entities)
        {
            await _orderRepository.RemoveRangeAsync(entities);
        }

        public async Task UpdateAsync(Order entity)
        {
            await _orderRepository.UpdateAsync(entity);
        }
    }
}
