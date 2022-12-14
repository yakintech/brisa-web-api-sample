using System;
using BrisaWebApiSample.Models.Dto.WebUser;
using BrisaWebApiSample.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BrisaWebApiSample.Models.Filter;
using Microsoft.AspNetCore.Authorization;

namespace BrisaWebApiSample.Controllers
{
    public class WebUserController : BaseController
    {

        [HttpPost]
        public IActionResult Add(CreateWebUserDto model)
        {
            BrisaContext brisaContext = new BrisaContext();


            WebUser webUser = new WebUser();
            webUser.Name = model.Name.Trim();
            webUser.Surname = model.Surname.Trim();
            webUser.Email = model.Email.ToLower();
            webUser.CategoryId = model.CategoryId;

            webUser.AddDate = DateTime.Now;
            webUser.UpdateDate = DateTime.Now;
            webUser.IsDeleted = false;



            brisaContext.WebUsers.Add(webUser);
            brisaContext.SaveChanges();



            return StatusCode(201, webUser);
        }



        [HttpGet]
        public IActionResult Get()
        {
            BrisaContext brisaContext = new BrisaContext();

            //select * from WebUsers
            //select * from WebUsers inner join Categories on WebUsers.CategoryId == Categories.ID
            var webusers = brisaContext.WebUsers
                    .Include(q => q.Category).ToList();



            var webUsers2 = brisaContext.WebUsers.Select(q => new
            {
                q.Email,
                q.Name,
                q.Id
            }).ToList();


            var webUsers3 = brisaContext.WebUsers.Where(q => q.CategoryId == 1).ToList();

            var webUsers4 = brisaContext.WebUsers.Where(q => q.Name.StartsWith("a")).ToList();

            var webUsers5 = brisaContext.WebUsers.Where(q => q.CategoryId == 2).Take(100).ToList();

            var webUsers6 = brisaContext.WebUsers.Where(q => q.CategoryId == 3)
                .Skip(10)
                .OrderByDescending(q => q.Name).ToList();


            List<WebUserListDto> model = brisaContext.WebUsers
                .Select(q => new WebUserListDto()
                {
                    Name = q.Name,
                    Surname = q.Surname
                }).ToList();
                




            return Ok(model);
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
            webUser.IsDeleted = true;


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

