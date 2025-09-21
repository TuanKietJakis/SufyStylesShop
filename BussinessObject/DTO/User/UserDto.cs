using BussinessObject.DTO.User;
using BussinessObject.Model;
using BussinessObject.Models;

public class UserDto
{
    public Guid UserId { get; set; }
    public string ProfileName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string UrlImage { get; set; }
    public string Bio { get; set; }
    public List<FollowDto> Followers { get; set; } = new List<FollowDto>();
    public List<FollowDto> Following { get; set; } = new List<FollowDto>();
    public string Phone { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public DateOnly? Birthday { get; set; }
    public bool? Gender { get; set; }
}

