using Lunchbox.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<TEntity> : Controller where TEntity : Entity
    {
        protected LunchboxDbContext context { get; set; }
        public GenericController(LunchboxDbContext context) {
            this.context = context;
        }

        [HttpGet]
        public virtual IActionResult Get()
        {
            Log.Debug("Get request on resource {0}", typeof(TEntity).Name);
            var entities = context.Set<TEntity>().ToList();
            return Ok(entities);
        }

        [HttpPut]
        public virtual IActionResult Put()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public virtual IActionResult Post()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public virtual IActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
