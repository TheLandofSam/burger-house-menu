
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MenuApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuApi.Controllers
{
    [Route("api/drink")]
    public class DrinkController : Controller
    {
        List<Drink> myDrinks = new List<Drink>();
        void makeDrinks(){
            //construct the menu
            var Soda = new Drink("Soda", 2.99f, false, 250);
            var Water = new Drink("Water", 2.99f, false, 0);
            var Port = new Drink("Port", 6.99f, true, 380);
            myDrinks.Add(Soda);
            myDrinks.Add(Water);
            myDrinks.Add(Port);
        }
    
    [HttpGet]    //THIS IS BROKEN
        public List<Drink> Get()
        {
            makeDrinks();
            return myDrinks;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Drink Get(int id)
        {
            makeDrinks();
            return myDrinks[id];
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