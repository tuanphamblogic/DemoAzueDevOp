using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
       

        public ValuesController()
        {
           
        }

         [HttpGet]
        public string Get()
        {
            return "Tuanph";
        }
    }
}