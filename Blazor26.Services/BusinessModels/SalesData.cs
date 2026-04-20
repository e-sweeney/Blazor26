using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor26.Services.BusinessModels
{
    public class SalesData
    {
        public float Month { get; set; } //FEATURE

        public float SalesAmount { get; set; } //LABEL

    }

    public class SalesPrediction
    {
        public float Score { get; set; }
    }
}
