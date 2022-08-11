#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace Posts.Models;
public class Post{
    [Key]
    // always name the id     the name of your tableId
    public int PostId {get;set;}
    [Required]
    [MinLength(2,ErrorMessage = "must be Longer than 2 characters")]
    [MaxLength(45,ErrorMessage = "must be shorter than 45 characters")]
    public string Topic {get;set;}
    [Required]
    [MinLength(2,ErrorMessage = "must be Longer than 2 characters")]
    public int Body {get;set;}
    [Display(Name = "URL Images(optional)")]
    public string ImgUrl {get;set;}
    public DateTime Created_At {get;set;} = DateTime.Now;
    public DateTime Updated_At {get;set;} = DateTime.Now;
    
}