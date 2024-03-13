using resume_api.Models;
using Microsoft.AspNetCore.Mvc;
using resume_api.Data;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
  private readonly ResumeContext _context;

  private readonly ILogger<UsersController> _logger;

  public UsersController(ILogger<UsersController> logger, ResumeContext context)
  {
    _logger = logger;
    _context = context;
  }

  // GET: api/users
  [HttpGet]
  public async Task<ActionResult<IEnumerable<User>>> GetUsers()
  {
    return await _context.Users.ToListAsync();
  }

  // GET: api/users/5
  [HttpGet("{userid}")]
  public async Task<ActionResult<User>> GetUser(int userid)
  {
    var user = await _context.Users.FindAsync(userid);

    if (user == null)
    {
      return NotFound();
    }

    return user;
  }

  // POST api/users
  [HttpPost]
  public async Task<ActionResult<User>> PostUser(User user)
  {
    _context.Users.Add(user);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetUser), new { userid = user.UserId }, user);
  }

  // PUT api/users/5
  [HttpPut("{userid}")]
  public async Task<IActionResult> PutUser(int userid, User user)
  {
    if (userid != user.UserId)
    {
      return BadRequest();
    }

    _context.Entry(user).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // DELETE api/users/5
  [HttpDelete("{userid}")]
  public async Task<IActionResult> DeleteUser(int UserId)
  {
    var user = await _context.Users.FindAsync(UserId);

    if (user == null)
    {
      return NotFound();
    }

    _context.Users.Remove(user);
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // dummy endpoint to test the database connection
  [HttpGet("test")]
  public string Test()
  {
    return "Hello World!";
  }
}