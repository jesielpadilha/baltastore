using System;
using System.Collections.Generic;
using BaltaStore.Domain.StoreContext.Entites;
using BaltaStore.Domain.StoreContext.Queries;

namespace BaltaStore.Domain.StoreContext.Repositories
{
    public interface ICustomerRepository
    {
        bool CheckDocument(string document);
        
        bool CheckEmail(string email);
        
        void Save(Customer customer);
        
        CustomerOrdersCountResult GetCustomerOrdersCount(string document);
        
        IEnumerable<ListCustomerQueryResult> Get();
        
        ListCustomerQueryResult Get(Guid id);
        IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id);
    }
}