using FrontPagePackages.DataContext;
using System.Web.Mvc;

namespace FrontPagePackages.Controllers
{
    public class PackagesItemsController : Controller
    {
        private DataProvider dataProvider;

        public PackagesItemsController()
        {
            dataProvider = new DataProvider();
        }

        public RedirectToRouteResult Index()
        {
            return RedirectToAction("PackageItems");
        }

        public ActionResult PackageItems()
        {
            return View();
        }

        public JsonResult GetListOfItems()
        {
            return Json(dataProvider.GetItems(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetListOfPackages()
        {
            return Json(dataProvider.GetPackages(), JsonRequestBehavior.AllowGet);
        }
    }
}