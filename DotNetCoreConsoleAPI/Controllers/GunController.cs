using DotNetCoreConsoleAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetCoreConsoleAPI.Controllers
{
    [Route("gun")]
    public class GunController : Controller
    {
        List<Gun> guns = new List<Gun>
        {
                  new Gun  {
            Id = 1,
            Name = "M-416",
            Type = "Assualt"
        },
                  new Gun  {
            Id = 2,
            Name = "UMP-45",
            Type = "SMG"
        }
        };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(guns);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(guns.FirstOrDefault(x=>x.Id == id));
        }
    }
}
