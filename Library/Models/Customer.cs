using System.Collections.Generic;

namespace Library.Models
{
  public class Customer
  {
    public Customer()
    {
      this.JoinEntities = new HashSet<CustomerBook>();
    }
    public int CustomerId {get;set;}
    public string Name {get; set;}
    public string PhoneNumber {get; set;}
    public string Address {get; set;}
    public virtual ICollection<CustomerBook> JoinEntities {get;set;}
  }
}