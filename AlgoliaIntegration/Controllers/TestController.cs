using Algolia.Search.Clients;
using Algolia.Search.Models.Search;
using AlgoliaIntegration.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoliaIntegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ISearchClient _client;
        public TestController(ISearchClient client)
        {
            _client = client;
        }

        [HttpGet("ListIndices")]
        public ActionResult GET()
        {
            return Ok(_client.ListIndices());
        }
        [HttpPost("SaveNewObject")]
        public ActionResult Post([FromBody] Departement dept)
        {
            _client.InitIndex("Departement").SaveObject(dept);
            return Ok();
        }
        [HttpGet("Search")]
        public ActionResult Search([FromQuery] string searchName)
        {
            var result = _client.InitIndex("Departement").Search<Departement>(new Query(searchName));
            return Ok(result);
        }
        [HttpGet("SearchPerPage")]
        public ActionResult SearchPerPage([FromQuery] BaseSearch search)
        {
            var result = _client.InitIndex("Departement").
                Search<Departement>(new Query(search.KeyWord) { HitsPerPage = search.PageSize, Page = search.PageNumber - 1 });
            return Ok(result);
        }
    }
}

