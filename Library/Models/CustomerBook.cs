namespace Library.Models
{
  public class CustomerBook
  {
    public int CustomerBookId {get;set;}
    public int BookId {get; set;}
    public int CustomerId {get;set;}
    public virtual Book Book {get; set;}
    public virtual Customer Customer {get; set;}

  }
}