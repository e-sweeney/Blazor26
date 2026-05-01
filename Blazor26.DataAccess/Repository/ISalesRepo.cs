using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Blazor26.Models.Models;

namespace Blazor26.DataAccess.Repository
{
    public interface ISalesRepo: IRepository<Sales>
    {
        Task<List<Sales>> ListOfSalesDataAsync();
    }
}
