using DB.Persistence.Base;
using DB.Persistence.Entities.Configuration;
using DB.Persistence.Interfaces;
using DB.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB.Persistence.Repositories
{
    public sealed class StatusRepository : IBaseRepository<Status, short, StatusModel>
    {
        public Task<bool> Exists(Expression<Func<Status, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<StatusModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<StatusModel>>> GetAll(Expression<Func<Status, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> GetEntityBy(short Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> Remove(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> Save(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> Update(Status entity)
        {
            throw new NotImplementedException();
        }
    }
}
