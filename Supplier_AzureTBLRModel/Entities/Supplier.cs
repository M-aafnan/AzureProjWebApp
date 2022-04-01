using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplier_AzureTBLRModel.Entities
{
    public class Supplier: TableEntity
    {
        public string Id { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string EmailID { get; set; }
    }
}
