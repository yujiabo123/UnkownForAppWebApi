using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace com.unkown.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexController : Controller
    {

        public async Task<ActionResult<string>> GetIndex()
        {
            return await Task.Run(() => "");

        }
    }
}