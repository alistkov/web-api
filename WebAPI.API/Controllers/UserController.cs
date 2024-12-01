using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Exceptions;
using WebAPI.Application.Interfaces;
using WebAPI.Application.Models;

namespace WebAPI.API.Controllers;

[ApiController]
[Route("/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public User[] GetAllUsers()
    {
        return _userService.GetAllUsers();
    }

    [HttpGet("{id:guid}")]
    public User? GetUserById([FromRoute] Guid id)
    {
        var user = _userService.GetUserById(id);
        
        if (user == null)
            throw new NotFoundException("User not found");
        
        return user;
    }

}