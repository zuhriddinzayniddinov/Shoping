namespace DBShoping.Models;

class OrderDetail
{
  public Guid OrderId { get; set; }
  public Guid ProductId { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }
  public double Discount { get; set; }
}