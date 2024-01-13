using System.Linq.Expressions;
using Av.ApiClients.Deputy.Models;
using Av.ApiClients.Deputy.Models.Resources;

namespace Av.ApiClients.Deputy.Clients
{
    public interface IQueryableResource<TRes>
        where TRes : IResource, new()
    {
        IQueryableResource<TRes> Where(Expression<Func<TRes, bool>> predicate);
        IQueryableResource<TRes> Include<TJoinRes>(Expression<Func<TRes, Join<TJoinRes>?>> predicate)
            where TJoinRes : IResource, new();

        IQueryableResource<TRes> Include<TAssocRes>(Expression<Func<TRes, Assoc<TAssocRes>?>> predicate)
            where TAssocRes : IResource, new();
        Query ToQuery();
        List<TRes> ToList();
    }

    internal class QueryableResource<TRes, TImpl> : IQueryableResource<TRes>
        where TRes : IResource, new()
    {
        public IQueryableResource<TRes> Include<TJoinRes>(Expression<Func<TRes, Join<TJoinRes>?>> predicate) where TJoinRes : IResource, new()
        {
            throw new NotImplementedException();
        }

        public IQueryableResource<TRes> Include<TAssocRes>(Expression<Func<TRes, Assoc<TAssocRes>?>> predicate) where TAssocRes : IResource, new()
        {
            throw new NotImplementedException();
        }

        public List<TRes> ToList()
        {
            throw new NotImplementedException();
        }

        public Query ToQuery()
        {
            throw new NotImplementedException();
        }

        public IQueryableResource<TRes> Where(Expression<Func<TRes, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
