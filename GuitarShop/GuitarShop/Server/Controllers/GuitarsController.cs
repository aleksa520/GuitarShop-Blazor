using GuitarShop.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarShop.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuitarsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public GuitarsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Guitar>>> Get()
        {
            return await context.Guitars.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetGuitar")]
        public async Task<ActionResult<Guitar>> Get(int id)
        {
            return await context.Guitars.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Guitar guitar)
        {
            context.Add(guitar);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetGuitar", new { id = guitar.Id }, guitar);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Guitar guitar)
        {
            context.Entry(guitar).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var guitar = new Guitar
            {
                Id = id
            };
            context.Remove(guitar);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
