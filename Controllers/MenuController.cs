using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuApi.Controllers
{
    [Route("api/menu")]
    public class MenuController : Controller
    {
        List<MenuItem> myMenu = new List<MenuItem>();
        void makeMenu(){
            //construct the menu
            var Hamburger = new MenuItem("Jake Burger", 5.99f);
            var Cheeseburger = new MenuItem("Mark Burger", 6.99f);
            var VeganBurger = new MenuItem("Vail Burger", 10.99f);
            myMenu.Add(Hamburger);
            myMenu.Add(Cheeseburger);
            myMenu.Add(VeganBurger);
        }

        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            makeMenu();
            return myMenu;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public MenuItem Get(int id)
        {
            makeMenu();
            return myMenu[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
