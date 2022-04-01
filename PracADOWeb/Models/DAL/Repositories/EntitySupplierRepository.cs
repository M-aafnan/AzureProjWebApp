using PracADOWeb.Models.DAL.IRepositories;
using PracADOWeb.Models.DBModels.CoreModels;
using PracADOWeb.Models.DBModels.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;

namespace PracADOWeb.Models.DAL.Repositories
{
    public class EntitySupplierRepository : ISupplierRepository
    {
        private SchoolManagmentEntities db = new SchoolManagmentEntities();
        public async Task Delete(PracADOWeb.Models.DBModels.CoreModels.Supplier model)
        {
            
            PracADOWeb.Models.DBModels.EntityModels.Supplier supplier = await db.Suppliers.Where(x => x.ID == model.Id).FirstOrDefaultAsync();
            db.Entry(supplier).State = EntityState.Deleted;
            await db.SaveChangesAsync();
        }

        public async Task<List<PracADOWeb.Models.DBModels.CoreModels.Supplier>> GetAll()
        {
            return await db.Suppliers.Select(x => new PracADOWeb.Models.DBModels.CoreModels.Supplier() { Address = x.Address, Contact = x.ContactNo, EmailID = x.EmailID, Id = x.ID, SupplierName = x.SupplierName }).ToListAsync();
        }

        public async Task<PracADOWeb.Models.DBModels.CoreModels.Supplier> GetById(string id)
        {
            return await db.Suppliers.Where(x=>x.ID == id).Select(x => new PracADOWeb.Models.DBModels.CoreModels.Supplier()
            {
                Address = x.Address,
                Contact = x.ContactNo,
                EmailID = x.EmailID,
                Id = x.ID,
                SupplierName = x.SupplierName
            }).FirstOrDefaultAsync();
        }

        public async Task Insert(PracADOWeb.Models.DBModels.CoreModels.Supplier model)
        {
            
            db.Suppliers.Add(new DBModels.EntityModels.Supplier() { ID = Guid.NewGuid().ToString(), Address = model.Address, ContactNo = model.Contact, EmailID = model.EmailID, SupplierName = model.SupplierName });
            await db.SaveChangesAsync();
        }

        public async Task Update(PracADOWeb.Models.DBModels.CoreModels.Supplier model)
        {
            PracADOWeb.Models.DBModels.EntityModels.Supplier supplier = await db.Suppliers.Where(x => x.ID == model.Id).FirstOrDefaultAsync();
            supplier.SupplierName = model.SupplierName;
            supplier.Address = model.Address;
            supplier.ContactNo = model.Contact;
            supplier.EmailID = model.EmailID;
            db.Entry(supplier).State = EntityState.Modified;
            await db.SaveChangesAsync();

        }
    }
}