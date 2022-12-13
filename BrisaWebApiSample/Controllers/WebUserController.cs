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

        [HttpGet]
        public IActionResult Get()
        {
            BrisaContext brisaContext = new BrisaContext();
            //select * from WebUsers
            var webusers = brisaContext.WebUsers.ToList();

            return Ok(webusers);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            BrisaContext brisaContext = new BrisaContext();

            WebUser webUser = brisaContext.WebUsers.FirstOrDefault(q => q.Id == id);

            //WebUser webUser1 = brisaContext.WebUsers.Find(id);
            //WebUser webUser1 = brisaContext.WebUsers.First(q => q.Id == id);

            if (webUser != null)
                return Ok(webUser);
            else
                return NotFound();
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            BrisaContext brisaContext = new BrisaContext();

            WebUser webUser = brisaContext.WebUsers.Find(id);

            brisaContext.WebUsers.Remove(webUser);
            brisaContext.SaveChanges();
            
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(WebUser webUser)
        {
            BrisaContext brisaContext = new BrisaContext();

            var entity = brisaContext.WebUsers.Find(webUser.Id);

            entity.Name = webUser.Name;
            entity.Surname = webUser.Surname;
            entity.Email = webUser.Email;
            entity.UpdateDate = DateTime.Now;


            brisaContext.SaveChanges();

            return Ok();

        }
    }
}

