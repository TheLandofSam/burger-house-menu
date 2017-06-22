using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuApi.Controllers
{
    [Route("api/menu")]
    public class EntreeController : Controller
    {
        List<Entree> myMenu = new List<Entree>();
        void makeMenu(){
            //construct the menu
            var Hamburger = new Entree("Jake Burger", 5.99f, 620);
            var Cheeseburger = new Entree("Mark Burger", 6.99f, 833);
            var VeganBurger = new Entree("Vail Burger", 10.99f, 556);
            myMenu.Add(Hamburger);
            myMenu.Add(Cheeseburger);
            myMenu.Add(VeganBurger);
            
        }

        [HttpGet]
        public List<Entree> Get()
        {
            makeMenu();
            return myMenu;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Entree Get(int id)
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
