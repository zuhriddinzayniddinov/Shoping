using DBShoping.Models;

public class Product
{
  public Guid ProductId { get; set; }
  public string ProductName { get; set; }
  public Guid SupplierId { get; set; }
  public Supplier Supplier { get; set; }
  public Guid CategoryId { get; set; }
  public Category Category { get; set; }
  public decimal Price { get; set; }
  public ICollection<OrderDetail> OrderDetails { get; set; }
}