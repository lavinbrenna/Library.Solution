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
    public virtual ICollection<CustomerBook> JoinEntities {get;set;}
  }
}

// Blood Type O

// It’s believed that people with blood type O were born to be natural leaders. They’re energetic, passionate, optimistic, friendly, loyal and easy going. They’re good communicators, knowing how to express their opinions or criticisms in a friendly way and making the other person not take it as an attack but as a constructive criticism and a way to improve. But at the same time they’re self-confident, ambitious, independent and realistic. These qualities together make them the perfect leaders. In addition, they have good intuition for business and go directly for their goals since they see things from a wider perspective, thinking about the future and without giving importance to small things. Although sometimes the fact that they don’t give importance to “small things” can be a problem since they might seem insensitive if for the other person that “small thing” is important. Other defects associated with people of blood type 0 is the lack of punctuality and that sometimes their confidence leads them to be arrogant and jealous.

// Currently 30% of Japanese are type O, being the second most majority group after A.