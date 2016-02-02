using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAPIDemoUI.Models;

namespace WebAPIDemoUI.Controllers
{
    public class WebjobController : Controller
    {
        // GET: Webjob
        public async Task<ActionResult> Index()
        {
            WebjobService service = new WebjobService();
            Task task = service.RunWebjob();
            await task;
            return View(service);
        }        
    }
}