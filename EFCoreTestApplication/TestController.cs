using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTestApplication
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly TestContext _context;

        public TestController(TestContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOwner()
        {
            var owner = new Owner();
            owner.OwnedObjects.Add(new Owned());

            await _context.AddAsync(owner);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOwner()
        {
            var owner = await _context.Owner.FirstOrDefaultAsync();
            owner.OwnedObjects.Add(new Owned());

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
