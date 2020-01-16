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
    public class GuitarBillsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public GuitarBillsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<GuitarBill>>> Get()
        {
            return await context.GuitarBills.ToListAsync();
        }

        [HttpGet("{id}", Name = "GetGuitarBill")]
        public async Task<ActionResult<GuitarBill>> Get(int id)
        {
            return await context.GuitarBills.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(GuitarBill guitarBill)
        {
            context.Add(guitarBill);
            await context.SaveChangesAsync();
            return new CreatedAtRouteResult("GetGuitarBill", new { id = guitarBill.Id }, guitarBill);
        }

        [HttpPut]
        public async Task<ActionResult> Put(GuitarBill guitarBill)
        {
            context.Entry(guitarBill).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var guitarBill = new GuitarBill
            {
                Id = id
            };
            context.Remove(guitarBill);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
