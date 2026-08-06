using CSharpWebAPI.Models;

namespace CSharpWebAPI.Mappers;

public class UserMapper
{
    public static UserDTO UserToDTO(User user)
    {
        if (user == null) return null;

        return new UserDTO
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Username = user.Username
        };
    }
}