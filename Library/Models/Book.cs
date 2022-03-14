using System.Collections.Generic;
namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.JoinEntities = new HashSet<CustomerBook>();
    }
    public int BookId{get; set;}
    public string Title {get;set;}
    public string Author {get;set;}
    public virtual ICollection<CategoryItem> JoinEntities {get;set;}
  }
}