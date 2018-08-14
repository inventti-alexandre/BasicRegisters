using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BasicRegisters.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class DadosIniciaisController : Controller
    {
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}