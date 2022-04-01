using PracADOWeb.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracADOWeb.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult BulkOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BulkOrder(HttpPostedFileBase file)
        {
            BlobManagementHelper blobManagement = new BlobManagementHelper();

            blobManagement.AddFileToBlob(file);
            return View();
        }
    }
}