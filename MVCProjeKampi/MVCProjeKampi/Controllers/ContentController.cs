using BusinessLayer.Concrate;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class ContentController : Controller
    {        
        ContentManager cm = new ContentManager(new EFContentDal());


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllContent(string p="")  //search  area
        {                 
            var values = cm.GetList(p);            
            return View(values);
        }

        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}