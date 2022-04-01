using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracADOWeb.Models.DBModels.CoreModels
{
    public class Supplier
    {
        public string Id { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string EmailID { get; set; }
    }
}