using DMS_API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml.Linq;


namespace DMS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[EnableCors("AllowLocalhost3000")] 
    public class CausesController : ControllerBase
    {
        private readonly ILogger<CausesController> _logger;
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public CausesController(ILogger<CausesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cause> GetCauses()
        {
            Random random = new Random();
            
            return Enumerable.Range(1, 5).Select(index => new Cause
            {
                id = Random.Shared.Next(1, 5),
                name = index.ToString(),
                img = "/assets/images/donate/donate-2-1.jpg",
                sub_title = chars[random.Next(chars.Length)].ToString(),
                banner_img = "/assets/images/slider/slider-v5-img-1.jpg",
                description = chars[random.Next(chars.Length)].ToString(),
            })
            .ToArray();
        }
        
        [HttpGet("{id}")]
        public ActionResult<Campaign> GetCause(int id)
        {
            Random random = new Random();
            var cause = new Cause();
            cause.id = Random.Shared.Next(1, 5);
            cause.name = string.Format("test test test test test {0}", id);
            cause.img = "/assets/images/donate/donate-2-1.jpg";
            cause.sub_title = chars[random.Next(chars.Length)].ToString();
            cause.banner_img = "/assets/images/slider/slider-v5-img-1.jpg";
            cause.description = chars[random.Next(chars.Length)].ToString();
            if (cause == null)
            {
                return NotFound();
            }

            return Ok(cause);
        }


    }
}
