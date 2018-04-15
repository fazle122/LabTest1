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
    [Route("api/Food")]
    public class FoodController : Controller
    {
        [HttpGet]
        [Route("GetFood")]
        public IActionResult GetFood()
        {
            List<Food> food = new List<Food>();
            food.Add(new Food() { Id = Guid.NewGuid().ToString(), Name = "a", Discription = "greate" });
            food.Add(new Food() { Id = Guid.NewGuid().ToString(), Name = "b", Discription = "good" });
            food.Add(new Food() { Id = Guid.NewGuid().ToString(), Name = "c", Discription = "moderate" });
            return this.Ok(food);
        }

        [HttpPost]
        [Route("SaveFood")]
        public IActionResult SaveFood([FromBody] Food food)
        {
            food.Id = Guid.NewGuid().ToString();
            return this.Ok(food);
        }

        [HttpDelete]
        [Route("DeleteFood")]
        public IActionResult DeleteFood(string id)
        {
            return this.Ok(id);
        }


        [HttpPut]
        [Route("EditFood")]
        public IActionResult EditFood(string id, Food foo)
        {
            if (id != null)
            {
                foo.Name = "test";
                foo.Discription = "test";
            }
            return this.Ok(foo);
        }


    }
}