using PracADOWeb.Models.DBModels.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracADOWeb.Models.DAL.IRepositories
{
    public interface ISupplierRepository
    {
        Task<List<Supplier>> GetAll();
        Task<Supplier> GetById(string id);
        Task Insert(Supplier model);
        Task Update(Supplier model);
        Task Delete(Supplier model);
    }
}
