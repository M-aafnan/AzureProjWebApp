using PracADOWeb.Models.DAL;
using PracADOWeb.Models.DAL.IRepositories;
using PracADOWeb.Models.DAL.Repositories;
using PracADOWeb.Models.DBModels.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PracADOWeb.Controllers
{
    public class SupplierController : Controller
    {
        ISupplierRepository supplierRepository ;
        

        public SupplierController()
        {
            supplierRepository = DBFactory.GetDatabase(DBFactory.DBName.ADO);
        }
        // GET: Supplier
        public async Task<ActionResult> Index()
        {
            IList<Supplier> suppliers  = await supplierRepository.GetAll();
            return View(suppliers);
        }

        // GET: Supplier/Details/5
        public async Task<ActionResult> Details(string id)
        {
            return View(await supplierRepository.GetById(id));
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public async Task<ActionResult> Create(Supplier model)
        {
            try
            {
                // TODO: Add insert logic here
                await supplierRepository.Insert(model);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Supplier/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            return View(await supplierRepository.GetById(id));
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(Supplier model)
        {
            try
            {
                // TODO: Add update logic here
                await supplierRepository.Update(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            return View(await supplierRepository .GetById(id));
        }

        // POST: Supplier/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(Supplier model)
        {
            try
            {
                // TODO: Add delete logic here
                await supplierRepository.Delete(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
