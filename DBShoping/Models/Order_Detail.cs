namespace DBShoping.Models;

public class OrderDetail
{
  public Guid OrderId { get; set; }
  public Order Order { get; set; }
  public Guid ProductId { get; set; }
  public Product Product { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }
  public double Discount { get; set; }
}