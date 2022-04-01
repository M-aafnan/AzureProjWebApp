using PracADOWeb.Models.DAL.IRepositories;
using PracADOWeb.Models.DBModels.CoreModels;
using Supplier_AzureTBLRModel.ViewModels;
using Supplier_AzureTBLRRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PracADOWeb.Models.DAL.Repositories
{
    public class AzureTBL_SupplierRepository : ISupplierRepository
    {
        private SupplierRepository_AzureTBL supplierRepo;

        public AzureTBL_SupplierRepository()
        {
            this.supplierRepo = new SupplierRepository_AzureTBL();
        }

        public async Task Delete(Supplier model)
        {
            await supplierRepo.DeleteSupplier(model.Id);
        }

        public async Task<List<Supplier>> GetAll()
        {
            List<Supplier_AzureTBLRModel.Entities.Supplier> suppliers =  await supplierRepo.GetSupplierList();
            return suppliers.Select(x => new Supplier() { Address = x.Address, Contact = x.Contact,EmailID = x.EmailID,Id = x.Id,SupplierName = x.SupplierName }).ToList();
        }

        public async Task<Supplier> GetById(string id)
        {
            Supplier_AzureTBLRModel.Entities.Supplier supplier =  await supplierRepo.GetSupplier(id);
            return new Supplier() { SupplierName = supplier.SupplierName,Id  = supplier.Id,Address = supplier.Address,Contact = supplier.Contact,EmailID = supplier.EmailID};
        }

        public async Task Insert(Supplier model)
        {
            await supplierRepo.AddSupplier(new SupplierAddVM() { Address = model.Address,Contact = model.Contact,EmailID = model.EmailID,SupplierName = model.SupplierName});
        }

        public async Task Update(Supplier model)
        {
            await supplierRepo.EditSupplier(new SupplierEditVM() { Address = model.Address, Contact = model.Contact, EmailID = model.EmailID, SupplierName = model.SupplierName, Id =model.Id });
        }
    }
}