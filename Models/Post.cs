
namespace WEBAPI.Models.Post {
public class Post
{
    public required string Title {get; set;}
    public required string Content {get; set;} 
    //public File media_urls;
    public required int Author_Id {get; set;}
    public required int Id {get; set;}
}
}