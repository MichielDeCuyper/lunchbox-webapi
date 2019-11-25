using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lunchbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lunchbox.Controllers
{
    public class RecipesController : GenericController<Recipe>
    {
        public RecipesController(LunchboxDbContext context) : base(context)
        { 
            
        }
    }
}
