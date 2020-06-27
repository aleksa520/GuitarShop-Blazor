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
    [Route("api/bill")]
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
            var bill = context.GuitarBills.Include(b => b.GuitarItems).Single(x => x.Id == id);
            //foreach(var i in bill.GuitarItems)
            //{
            //    var item = context.GuitarBillItem.Include(it => it.Guitar).Single(y => y.Id == i.Id);
            //    bill.GuitarItems.Add(item);
            //}
            ////return await context.GuitarBills.FirstOrDefaultAsync(x => x.Id == id);
            return bill;
        }

        [HttpPost]
        public async Task<ActionResult> Post(GuitarBill guitarBill)
        {
            guitarBill.Date = DateTime.ParseExact(guitarBill.DatumTest, "dd/MM/yyyy HH:mm:ss", null);
            foreach (GuitarBillItem item in guitarBill.GuitarItems)
            {
                context.Entry(item.Guitar).State = EntityState.Unchanged;
            }
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
