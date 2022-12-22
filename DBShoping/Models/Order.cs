namespace DBShoping.Models;

public class Order
{
  public Guid OrderId { get; set; }
  public Guid CustomerId { get; set; }
  public Customer Customer { get; set; }
  public Guid EmployeeId { get; set; }
  public Employee Employee { get; set; }
  public Guid ShipperId { get; set; }
  public Shipper Shipper { get; set; }
  public DateTimeOffset OrderDate { get; set; }
  public DateTimeOffset ShippedDate { get; set; }
  public Transport ShipVia { get; set; }
  public string ShipName { get; set; }
  public string City { get; set; }
  public string Region { get; set; }
  public string Country { get; set; }
  public ICollection<OrderDetail> OrderDetails { get; set; }
}

public enum Transport
{
  Avia,
  Ship,
  Avto,
  Bicycle,
  People,
  Drone
}