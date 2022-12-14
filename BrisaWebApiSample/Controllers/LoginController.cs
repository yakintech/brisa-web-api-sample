using System;
using BrisaWebApiSample.Models;
using BrisaWebApiSample.Models.Dto.WebUser;
using Microsoft.AspNetCore.Mvc;

namespace BrisaWebApiSample.Controllers
{
    public class LoginController : BaseController
    {


        [HttpPost]
        public IActionResult Add(LoginDto model)
        {
            if(model.EMail == "a@a.com" && model.Password == "123")
            {
                var tokenHandler = new TokenHandler();

                var tokenData = tokenHandler.CreateAccessToken();

                return Ok(tokenData);
            }
            else
            {
                return StatusCode(401);
            }
        }
       
    }
}

