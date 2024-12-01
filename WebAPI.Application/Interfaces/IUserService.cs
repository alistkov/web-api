using WebAPI.Application.Models;

namespace WebAPI.Application.Interfaces;

public interface IUserService
{
    User[] GetAllUsers();
    User? GetUserById(Guid id);
}