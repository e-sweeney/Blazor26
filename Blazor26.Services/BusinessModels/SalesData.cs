using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.Services.BusinessModels
{
    public class SalesData
    {
        public float Month { get; set; }
        public float SalesAmount { get; set; }
    }
    public class SalesPredication
    {
        public float Score { get; set; }
    }
}
