namespace DBShoping.Models;
public class Shipper
{
  public Guid ShipperId { get; set; }
  public string CompanyName { get; set; }
  public string Phone { get; set; }
  public ICollection<Order> Orders { get; set; }
}