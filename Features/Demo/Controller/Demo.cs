using Asteya.Features.Services;
using Microsoft.AspNetCore.Mvc;

namespace Asteya.Features
{
    [Route("~/demo")]
    public class Demo : Controller
    {
        private readonly IDemoServices _demoServices;
        public Demo(IDemoServices demoServices)
        {
            _demoServices = demoServices;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(_demoServices.Method());
        }
    }
}
