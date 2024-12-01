using WebAPI.Application.Interfaces;
using WebAPI.Application.Models;

namespace WebAPI.Application.Services;

public class UserService : IUserService
{
    private readonly User[] users =
    [
        new User { Id = new Guid("9f1b3815-2206-4bef-accf-16e91dd45974"), FirstName = "Max", LastName = "Verstappen", Birthday = new DateTime(1997, 9,30) },
        new User { Id = new Guid("e0106a51-80e0-4a01-bad5-f4a3c7e8717b"), FirstName = "Lando", LastName = "Norris", Birthday = new DateTime(1999, 11, 13) },
        new User { Id = new Guid("0e3758c4-586a-4c6a-9405-6d7a67638849"), FirstName = "Charles", LastName = "Leclerc", Birthday = new DateTime(1996, 10, 16) },
        new User { Id = new Guid("d97445ef-7a79-49f2-9b21-1d3f8c248a8d"), FirstName = "Oscar", LastName = "Piastri", Birthday = new DateTime(2001, 04, 06) },
        new User { Id = new Guid("f772fc39-e313-4b72-86e3-2d3ec6351aab"), FirstName = "Carlos", LastName = "Sainz", Birthday = new DateTime(1994, 09, 01) },
        new User { Id = new Guid("e6799762-3dfc-4bbb-ba0a-b3f8820119f0"), FirstName = "George", LastName = "Russell", Birthday = new DateTime(1998, 02, 15) },
        new User { Id = new Guid("d4149e15-327a-423e-95fb-228de7ed5ffe"), FirstName = "Lewis", LastName = "Hamilton", Birthday = new DateTime(1985, 01, 07) },
    ];
    
    public User[] GetAllUsers()
    {
        return users;
    }

    public User? GetUserById(Guid id)
    {
        return users.FirstOrDefault(u => u.Id == id);
    }
}