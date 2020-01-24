using Services.Contracts;
using System;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class ServerController : Controller
    {
        private readonly Lazy<IServerService> serversService;

        public ServerController(Lazy<IServerService> serversService)
        {
            this.serversService = serversService;
        }

        public ActionResult Index()
        {
            var all = serversService.Value.GetAll();

            return View();
        }
    }
}