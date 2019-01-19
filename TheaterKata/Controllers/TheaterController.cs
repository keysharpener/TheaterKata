﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TheaterKata.Framework;
using TheaterKata.Framework.Domain;

namespace TheaterKata.Controllers
{
    [Route("api/[controller]")]
    public class TheaterController : Controller
    {
        private readonly ITheaterProvider _theaterProvider;

        public TheaterController(ITheaterProvider theaterProvider)
        {
            _theaterProvider = theaterProvider;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Theater> Get()
        {
            return _theaterProvider.GetAllTheaters();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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