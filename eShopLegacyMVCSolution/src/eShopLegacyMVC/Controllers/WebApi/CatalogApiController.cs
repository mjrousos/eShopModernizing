﻿using eShopLegacyMVC.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace eShopLegacyMVC.Controllers.WebApi
{
    public class CatalogApiController : ApiController
    {
        private ICatalogService service;

        public CatalogApiController(ICatalogService service)
        {
            this.service = service;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}