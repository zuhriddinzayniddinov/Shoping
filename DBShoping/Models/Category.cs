namespace DBShoping.Models;

public class Category
{
  public Guid CategoryId { get; set; }
  public string CategoryName { get; set; }
  public string Description { get; set; }
  public ICollection<Product> Products { get; set; }
}