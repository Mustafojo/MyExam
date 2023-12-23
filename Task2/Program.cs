
var Post1 = new Post();
Post1.Title = "In behtarin ast";
Post1.Description = "Man kushish kardam";
Post1.LikeCount = 20;
Post1.Comments = "Mo bo shumo hastem";


var Post2 = new Post();
Post2.Title = "In bad ast";
Post2.Description = "Man kushish nakardam";
Post2.LikeCount = 230;
Post2.Comments = "Mo bo shumo nestem";



var Post3 = new Post();
Post3.Title = "In behtarin nest";
Post3.Description = "Man kushish karda budam";
Post3.LikeCount = 200;
Post3.Comments = "Mo bo shumo hastem";



var Post4 = new Post();
Post4.Title = "In behtarin ast";
Post4.Description = "Man kushish kardam";
Post4.LikeCount = 120;
Post4.Comments = "Mo bo shumo hastem";



var Post5 = new Post();
Post5.Title = "In behtarin ast";
Post5.Description = "Man kushish kardam";
Post5.LikeCount = 720;
Post5.Comments = "Mo bo shumo hastem";





System.Console.WriteLine($"{Post1.Title}");
System.Console.WriteLine($"{Post1.Description}");
System.Console.WriteLine($"{Post1.LikeCount}");
System.Console.WriteLine($"{Post1.Comments}");

System.Console.WriteLine($"{Post2.Title}");
System.Console.WriteLine($"{Post2.Description}");
System.Console.WriteLine($"{Post2.LikeCount}");
System.Console.WriteLine($"{Post2.Comments}");

System.Console.WriteLine($"{Post3.Title}");
System.Console.WriteLine($"{Post3.Description}");
System.Console.WriteLine($"{Post3.LikeCount}");
System.Console.WriteLine($"{Post3.Comments}");

System.Console.WriteLine($"{Post4.Title}");
System.Console.WriteLine($"{Post4.Description}");
System.Console.WriteLine($"{Post4.LikeCount}");
System.Console.WriteLine($"{Post4.Comments}");

System.Console.WriteLine($"{Post5.Title}");
System.Console.WriteLine($"{Post5.Description}");
System.Console.WriteLine($"{Post5.LikeCount}");
System.Console.WriteLine($"{Post5.Comments}");





class Post
{
    public string Title;
    public string Description;
    public int LikeCount;
    public string Comments;
    public bool IsPublished ;

    public string Publish()
    {
        return "The post is published.";
        IsPublished = true;
    }
   
    public string Like()
    {
        return $"{LikeCount + 1}";
    }
    public string Comment(string message)
    {
        return $"{Comments = message}";
    }
    
}
