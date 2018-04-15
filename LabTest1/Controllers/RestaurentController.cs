using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabTest1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabTest1.Controllers
{
    [Produces("application/json")]
    [Route("api/Restaurent")]
    public class RestaurentController : Controller
    {

        [HttpGet]
        [Route("GetRestaurent")]
        public IActionResult GetRestaurent()
        {
            List<Restaurent> res = new List<Restaurent>();
            res.Add(new Restaurent() { Id = Guid.NewGuid().ToString(), Name = "Fokhruddin", Discription = "Biriany" });
            res.Add(new Restaurent() { Id = Guid.NewGuid().ToString(), Name = "Chillox", Discription = "Barger" });
            res.Add(new Restaurent() { Id = Guid.NewGuid().ToString(), Name = "Bonoful", Discription = "sweet" });
            return this.Ok(res);
        }

        [HttpPost]
        [Route("SaveRestaurent")]
        public IActionResult SaveRestaurent([FromBody] Restaurent res)
        {
            res.Id = Guid.NewGuid().ToString();
            return this.Ok(res);
        }

        [HttpDelete]
        [Route("DeleteRestaurent")]
        public IActionResult DeleteRestaurent(string id)
        {
            return this.Ok(id);
        }

        [HttpPut]
        [Route("EditRestaurent")]
        public IActionResult EditRestaurent(string id,Restaurent res)
        {
            if(id != null)
            {
                res.Name = "updateRes";
                res.Discription = "updateTest";
            }
            return this.Ok(res);
        }
    }
}