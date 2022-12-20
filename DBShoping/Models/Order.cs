using DBShoping.Models;

class Order
{
  public Guid OrderId { get; set; }
  public Guid CustomerId { get; set; }
  public Guid EmployeeId { get; set; }
  public DateTimeOffset OrderDate { get; set; }
  public DateTimeOffset ShippedDate { get; set; }
  public Transport ShipVia { get; set; }
  public string ShipName { get; set; }
  public string City { get; set; }
  public string Region { get; set; }
  public string Country { get; set; }
}
enum Transport
{
  Avia,
  Ship,
  Avto,
  Bicycle,
  People,
  Drone
}