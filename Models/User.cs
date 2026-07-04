
namespace WEBAPI.Models.User {
public class User
{
    public required string Name {get; set;}
    public required string Surname {get; set;}
    public required string Login {get; set;}
    public required string Email {get; set;}
    public required string Password_hash {get; set;}
    public required string Bio {get; set;}
    public required int Id {get; set;}

}
}