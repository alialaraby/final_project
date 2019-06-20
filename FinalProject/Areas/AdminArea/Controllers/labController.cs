using FinalProject.BLL.BusinessLayer;
using FinalProject.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Areas.AdminArea.Controllers
{
    public class labController : Controller
    {
        labBLL bll = new labBLL();
        // GET: AdminArea/lab
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getlabs()
        {
            List<labVM> allLabs = bll.getAllLabs();
            return View(allLabs);

        }
    }
}