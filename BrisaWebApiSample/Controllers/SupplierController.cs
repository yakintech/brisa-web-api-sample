using System;
using BrisaWebApiSample.Models;
using BrisaWebApiSample.Models.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BrisaWebApiSample.Controllers
{


    public class SupplierController : BaseController
    {

    
        [HttpGet]
        public IActionResult Get()
        {
            var suppliers = new List<Supplier>();

            var supplier1 = new Supplier()
            {
                CompanyName = "Apple",
                ContactTitle = "Manager",
                ContactName = "Ali"
            };

            var supplier2 = new Supplier()
            {
                CompanyName = "Huawei",
                ContactTitle = "Manager",
                ContactName = "Ayça"
            };

            suppliers.Add(supplier1);
            suppliers.Add(supplier2);

            return Ok(suppliers);

        }


        [HttpPost]
        public IActionResult Add(Supplier supplier)
        {
            //

            return StatusCode(201, supplier);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            //get by id...
            return Ok();

        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            //Delete operasyonları...

            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Supplier model)
        {
            //update operasyonlaro
            return Ok();
        }

    }
}
