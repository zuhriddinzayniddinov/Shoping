using DBShoping.Models;

class Product
{
  public Guid ProductId { get; set; }
  public string ProductName { get; set; }
  public Guid SupplierId { get; set; }
  public Guid CategoryId { get; set; }
  public decimal Price { get; set; }
}