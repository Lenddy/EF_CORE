/* 
Disabled Warning: "Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable."
We can disable this safely because we know the framework will assign non-null values when it constructs this class for us.
*/
#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
// the MyContext class representing a session with our MySQL database, allowing us to query for or save data
namespace Posts.Models;
// this change from MyContext to DB
public class DB: DbContext{

    public DB(DbContextOptions options):base(options){}
       // the "Posts" table name will come from the DbSet property name
    public DbSet<Post> post {get; set;}
}





