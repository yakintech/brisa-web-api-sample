using System;
using BrisaWebApiSample.Models.ORM;
using Microsoft.AspNetCore.Mvc;

namespace BrisaWebApiSample.Controllers
{
    public class WebUserController : BaseController
    {

        [HttpPost]
        public IActionResult Add(WebUser webUser)
        {
            BrisaContext brisaContext = new BrisaContext();

            brisaContext.WebUsers.Add(webUser);
            brisaContext.SaveChanges();

            return StatusCode(201, webUser);
        }
    }
}

