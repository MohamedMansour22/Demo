using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoCode.Models;

namespace DemoCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Table1Controller : ControllerBase
    {
        private readonly DemodbContext _context;

        public Table1Controller(DemodbContext context)
        {
            _context = context;
        }

        // GET: api/Table1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table1>>> GetTable1()
        {
            return await _context.Table1.ToListAsync();
        }
        
        private bool Table1Exists(Guid id)
        {
            return _context.Table1.Any(e => e.Id == id);
        }
    }
}
