using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("/User")]
class UserController : ControllerBase
{
    string name;
    string surname;
    string login;
    string password;
    int id;


    UserController(string _name,string _surname,string _login,string _password)
    {
        this.name = _name ;
        this.surname = _surname;
        this.login = _login;
        this.password = _password;
        this.id = _id;
    }
static int _id;
}

