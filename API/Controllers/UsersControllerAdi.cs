using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersControllerAdi(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsersAdi()
    {
        var UsersAdi = await context.Users.ToListAsync();
        return UsersAdi;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<AppUser>> GetUserAdi(int id)
    {
        var UserAdi = await context.Users.FindAsync(id);

        if(UserAdi == null)
            return NotFound();
        return UserAdi;
    }
}
