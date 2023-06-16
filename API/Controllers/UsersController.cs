using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly KSIUContext _context;

        public UsersController(KSIUContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUser>>> GetUsers() 
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
