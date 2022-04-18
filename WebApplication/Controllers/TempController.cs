namespace WebApplication.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using WebApplication.Models;

    [ApiController]
    [Route("/api/[controller]")]
    public class TempController : ControllerBase
    {
        private ApplicationContext db;

        public TempController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products;
        }
    }
}
