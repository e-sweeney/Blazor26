using Blazor26.DataAccess.DataAccess;
using Blazor26.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.DataAccess.Repository
{
    public class SalesRepo : Repository<Sales>, ISalesRepo
    {
        private readonly AppDBContext _dbContext;
        public SalesRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
