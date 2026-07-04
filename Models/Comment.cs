
namespace WEBAPI.Models.Comment {
public class Comment{
    public required string Title {get; set;}
    public required string Content {get; set;} 

    public required int Author_Id {get; set;}
    public required int Post_Id {get; set;}
    public required int Id {get; set;}
}
}