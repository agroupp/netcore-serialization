using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serialization.Data;

namespace Serialization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        public async Task<IActionResult> GetAsync()
        {
            return new ObjectResult(
                new DataClassA { NameField = "NameField", LongNameField = "LongNameField", NumericField = 42, BooleanField = true }
                );
        }
    }
}